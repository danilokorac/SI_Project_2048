using DataAccessLayer;
using System;

namespace BusinessLayer
{
    public class BLayer
    {
        public readonly PlayerRepository pr;

        public BLayer()
        {
            pr = new PlayerRepository();
        }
    }
}
