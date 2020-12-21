using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class PersonalScore
    {
        public int PlayerID { get; set; }
        public int Score { get; set; }
        public DateTime DateAndTime { get; set; }
        public int NumberOfMoves { get; set; }
        public DateTime TimePlayed { get; set; }
    }
}
