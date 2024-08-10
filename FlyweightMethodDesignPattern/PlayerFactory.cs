using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightMethodDesignPattern
{
    public class PlayerFactory
    {
        private static Dictionary<string, IPlayer> playerDisctionary = new Dictionary<string, IPlayer>();
        public static IPlayer GetPlayer(string type)
        {
            IPlayer player = type == "Terrorist"? new Terrorist():new CounterTerrorist();
            if(playerDisctionary.ContainsKey(type))
                player = playerDisctionary[type];
            else
            {
                switch(type)
                {
                    case "Terrorist":
                        Console.WriteLine("Terrorist created");
                        break;
                    case "Counter terrorist":
                        Console.WriteLine("Counter terrorist created");
                        break;
                    default:
                        Console.WriteLine("Unreachable code");
                        break;
                }
                playerDisctionary.Add(type, player);
            }
            return player;
        }
    }
}
