using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BLayer
    {
        private readonly PlayerRepository pr;
        

        public BLayer()
        {
            pr = new PlayerRepository();
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
    }
}
