using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightMethodDesignPattern
{
    public class Terrorist : IPlayer
    {
        private const string task = "Plant a bomb";
        private string weapon;
        public void AssignWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public void Mession()
        {
            Console.WriteLine($"Counter terrorist weapon is {weapon} and task is {task}");
        }
    }
}
