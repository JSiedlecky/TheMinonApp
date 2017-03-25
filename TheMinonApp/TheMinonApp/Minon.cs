using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMinonApp
{
    class Minon
    {
        //FIELDS
        public string Name;
        public int AmountOfEyes;
        public int AmountOfBananas;
        public happiness Happiness;


        //METHODS
        public void FullInfo()
        {
            string info = "Minon " + this.Name + " has " + this.AmountOfEyes + " eyes, " + this.AmountOfBananas + " bananas and is " + this.Happiness + " about that";
            Console.WriteLine("*");
            Console.WriteLine(info);
            Console.WriteLine("*");
        }
    }

    enum happiness
    {
        sad, 
        mediocre,
        happy
    }
}
