using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UC_Tableau_de_bord;

namespace UC_Tab_de_bord
{
    public class MesDatas
    {
        public static List<Probleme> ChargerProblemesDepuisBase()
        {
            List<Probleme> liste = new List<Probleme>();
            string requete = @"SELECT 
    Id, 
    motifAppel AS Titre, 
    compteRendu AS Description, 
    DateHeureDepart AS DateSignalement, 
    idNatureSinistre AS NiveauUrgence, 
    idCaserne AS Caserne, 
    DateHeureRetour AS DateRetour 
FROM Mission";


            using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    liste.Add(new Probleme
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titre = reader["Titre"].ToString(),
                        Description = reader["Description"].ToString(),
                        DateSignalement = DateTime.Parse(reader["DateSignalement"].ToString()),
                        NiveauUrgence = reader["NiveauUrgence"].ToString(),
                        Caserne = reader["Caserne"].ToString(),
                        DateRetour = reader["DateRetour"] != DBNull.Value ? DateTime.Parse(reader["DateRetour"].ToString()) : (DateTime?)null
                    });
                }
            }

            return liste;
        }
        public static MissionComplete GetMissionParId(int id)
        {
            MissionComplete mission = new MissionComplete
            {
                Pompiers = new List<string>(),
                Engins = new List<string>()
            };

            // --- Requête principale avec jointures ---
            string requete = @"
        SELECT 
            M.dateHeureDepart, 
            M.dateHeureRetour, 
            M.motifAppel, 
            M.adresse, 
            M.cp, 
            M.ville,
            M.terminee, 
            M.compteRendu, 
            N.libelle AS nomSinistre,
            C.nom AS nomCaserne
        FROM Mission M
        JOIN NatureSinistre N ON M.idNatureSinistre = N.id
        JOIN Caserne C ON M.idCaserne = C.id
        WHERE M.id = @id";

            using (var cmd = new SQLiteCommand(requete, Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        mission.Id = id;
                        mission.Titre = reader["nomSinistre"].ToString();
                        mission.Description = reader["motifAppel"].ToString();
                        mission.Adresse = reader["adresse"].ToString();
                        mission.DateDebut = DateTime.Parse(reader["dateHeureDepart"].ToString());
                        mission.DateRetour = reader["dateHeureRetour"] != DBNull.Value
                            ? DateTime.Parse(reader["dateHeureRetour"].ToString())
                            : (DateTime?)null;
                        mission.Caserne = reader["nomCaserne"].ToString();
                        mission.CompteRendu = reader["compteRendu"] != DBNull.Value
                            ? reader["compteRendu"].ToString()
                            : "Non renseigné.";
                    }
                }
            }

            // --- Récupération des pompiers associés à la mission via Mobiliser ---
            using (var cmd = new SQLiteCommand(@"
        SELECT P.Nom 
        FROM Mobiliser M
        JOIN Pompier P ON P.matricule = M.matriculePompier
        WHERE M.idMission = @id", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        mission.Pompiers.Add(reader.GetString(0));
                }
            }

            // --- Récupération des engins associés à la mission via PartirAvec et TypeEngin ---
            using (var cmd = new SQLiteCommand(@"
        SELECT TE.nom 
        FROM PartirAvec PA
        JOIN Engin E ON E.codeTypeEngin = PA.codeTypeEngin AND E.numero = PA.numeroEngin
        JOIN TypeEngin TE ON TE.code = E.codeTypeEngin
        WHERE PA.idMission = @id", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        mission.Engins.Add(reader.GetString(0));
                }
            }

            return mission;
        }

    }






}

