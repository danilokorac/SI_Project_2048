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

        public BLayer()
        {
            pr = new PlayerRepository();
        }

        public bool PlayerLogIn(string username,string password)
        {
            for(int i = 0; i < pr.GetAllPlayers().Count; i++)
            {
                if (pr.GetAllPlayers()[i].Username == username && pr.GetAllPlayers()[i].Username == password)
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
