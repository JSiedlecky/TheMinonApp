using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMinonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Minon janek = new Minon("Janek",2,5);
            janek.FullInfo();
            janek.EatBanana();
            janek.FullInfo();
            janek.EatBanana();
            janek.FullInfo();
            janek.EatBanana();
            janek.FullInfo();
            Console.ReadLine();
        }
    }
}
