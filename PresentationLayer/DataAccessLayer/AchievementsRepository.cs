using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class AchievementsRepository
    {
        public int InsertAchievement(Achievement a)
        {
            int result;
            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                string commandText = string.Format("INSERT INTO Achievements VALUES( {0}, {1}, {2},)", a.CompletedGame, a.BetterThanAverageMoves, a.BetterThanAverageTime);
                SqlCommand com = new SqlCommand(commandText, con);

                con.Open();
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public int UpdateAchievement(Achievement a, int id)
        {
            int result;
            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                string commandText = string.Format("UPDATE Achievements SET CompletedGame = {0}, BetterThanAverageMoves = {1}, BetterThanAverageTime = {2}" +
                    "WHERE Id = {3} ", a.CompletedGame, a.BetterThanAverageMoves, a.BetterThanAverageTime, id);
                SqlCommand com = new SqlCommand(commandText, con);

                con.Open();
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public List<Achievement> GetAchievements(int id)
        {
            List<Achievement> a = new List<Achievement>();

            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = string.Format("SELECT * FROM Achievements" + 
                    "WHERE Id = {0}", id);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Achievement ac = new Achievement();
                    ac.PlayerID = dr.GetInt32(0);
                    ac.CompletedGame = dr.GetBoolean(1);
                    ac.BetterThanAverageMoves = dr.GetBoolean(2);
                    ac.BetterThanAverageTime = dr.GetBoolean(3);

                    a.Add(ac);
                }
                return a;
            }
        }
    }
}
