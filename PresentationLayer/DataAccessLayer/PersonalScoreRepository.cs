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
    }
}
