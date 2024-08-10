using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightMethodDesignPattern
{
    public static class ConterStrike
    {

        public static string[] playerType = { "Terrorist", "Counter terrorist" };
        public static string[] weapons = { "Maverick", "Gut", " Knife", "Eagle", "Desert" };
        public static string GetRandPlayerType()
        {
            Random random = new Random();
            int randInt = random.Next(playerType.Length);
            return playerType[randInt];
        }
        public static string GetRandWeapon()
        {
            Random random = new Random();
            int randInt = random.Next(weapons.Length);
            return weapons[randInt];
        }
    }
}
