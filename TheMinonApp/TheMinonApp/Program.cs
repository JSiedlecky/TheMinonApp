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
            Minon janek = new Minon();
            janek.Name = "Janek";
            janek.AmountOfBananas = 10;
            janek.AmountOfEyes = 3;
            janek.Happiness = happiness.sad;
            janek.FullInfo();
        }
    }
}
