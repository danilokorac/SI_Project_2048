using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class PersonalScoreRepository
    {
        public int InsertPersonalScore(PersonalScore ps)
        {
            int result;
            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                string commandText = string.Format("INSERT INTO Personal_Scores VALUES( {0}, {1}, {2}, {3})", ps.Score, ps.DateAndTime, ps.NumberOfMoves, ps.TimePlayed);
                SqlCommand com = new SqlCommand(commandText, con);

                con.Open();
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public List<PersonalScore> GetAllPersonalScores()
        {
            List<PersonalScore> ps = new List<PersonalScore>();

            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT * FROM Personal_Scores";

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    PersonalScore ps1 = new PersonalScore();
                    ps1.PlayerID = dr.GetInt32(0);
                    ps1.Score = dr.GetInt32(1);
                    ps1.DateAndTime = dr.GetDateTime(2);
                    ps1.NumberOfMoves = dr.GetInt32(3);
                    ps1.TimePlayed = dr.GetString(4);

                    ps.Add(ps1);
                }


                return ps;
            }
        }
    }
}
