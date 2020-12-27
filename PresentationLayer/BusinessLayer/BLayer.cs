using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BLayer
    {
        private readonly PlayerRepository pr;
        private static Player p = new Player();
        private readonly PersonalScoreRepository psr = new PersonalScoreRepository();
        public BLayer()
        {
            pr = new PlayerRepository();
        }

        public bool PlayerLogIn(string username,string password)
        {
            for(int i = 0; i < pr.GetAllPlayers().Count; i++)
            {
                if (pr.GetAllPlayers()[i].Username.Equals(username) && pr.GetAllPlayers()[i].Password.Equals(password))
                {
                    p.PlayerID = pr.GetAllPlayers()[i].PlayerID;
                    p.Username = pr.GetAllPlayers()[i].Username;
                    p.Password = pr.GetAllPlayers()[i].Password;
                    p.InGameName = pr.GetAllPlayers()[i].InGameName;
                    return true;
                }
            }
            return false;
        }

        public List<Player> GetPlayerList() 
        {
            return pr.GetAllPlayers();
        }

        public List<PersonalScore> getPlayerPersonalScores()
        {
            List<PersonalScore> score = new List<PersonalScore>();
            for(int i=0;i< psr.GetAllPersonalScores().Count; i++)
            {
                if (p.PlayerID == psr.GetAllPersonalScores()[i].PlayerID)
                {
                    PersonalScore ps = new PersonalScore();
                    ps.PlayerID = psr.GetAllPersonalScores()[i].PlayerID;
                    ps.Score = psr.GetAllPersonalScores()[i].Score;
                    ps.DateAndTime = psr.GetAllPersonalScores()[i].DateAndTime;
                    ps.TimePlayed = psr.GetAllPersonalScores()[i].TimePlayed;
                    score.Add(ps);
                }
            }
            return score;
        }
        public bool insertPlayerScore(PersonalScore ps)
        {
            if (psr.InsertPersonalScore(ps) > 0)
                return true;
            return false;

        }
        public bool InsertNewPlayer(Player pl)
        {
            if (pr.InsertPlayer(pl) > 0)
                return true;
            return false;
        }

        public Player getPlayer()
        {
            return p;
        }
    }
}
