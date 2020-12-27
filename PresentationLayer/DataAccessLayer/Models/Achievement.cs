using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Achievement
    {
        public int AchievementID { get; set; }
        public bool CompletedGame { get; set; }
        public bool BetterThanAverageMoves { get; set; }
        public bool BetterThanAverageTime { get; set; }
        public int PA_ID { get; set; }
    }
}
