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
        private string Name;
        private int AmountOfEyes;
        private int AmountOfBananas;
        private happiness Happiness;

        //CONSTRUCTORS
        public Minon(string nName, int nAoE, int nAoB)
        {
            this.Name = nName;
            this.AmountOfEyes = nAoE;
            this.AmountOfBananas = nAoB;
            this.Happiness = SetHappiness(nAoB);
        }

        //PUBLIC METHODS 
        public void FullInfo()
        {
            string info = "Minon " + this.Name + " has " + this.AmountOfEyes + " eyes, " + this.AmountOfBananas + " bananas and is " + this.Happiness + " becouse of that.";
            Console.WriteLine("*");
            Console.WriteLine(info);
            Console.WriteLine("*");
        }

        public void EatBanana()
        {
            if (this.AmountOfBananas >= 1) this.AmountOfBananas--;
            else this.AmountOfBananas = 0;

            this.Happiness = SetHappiness(this.AmountOfBananas);
        }

        public void EatAllBananas()
        {
            this.AmountOfBananas = 0;

            this.Happiness = SetHappiness(this.AmountOfBananas);
        }

        //PRIVATE METHODS
        private happiness SetHappiness(int AoB)
        {
            if (AoB < 1) return happiness.sad;
            if (AoB >= 1 && AoB < 3) return happiness.happy;
            if (AoB >= 3) return happiness.euphoric;

            return happiness.sad;
        }
    }

    enum happiness
    {
        sad, //less then 1 banana
        happy, //between 1 and 3 bananas
        euphoric //3 and more bananas
    }
}

