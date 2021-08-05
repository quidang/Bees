using System.Globalization;
using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {       
    static void Main(string[] args)
        {   // Create 2 Beehives 
            // Input Bees

            List<Bee> BeesList1 = new List<Bee>();
            BeesList1.AddRange(new List<Bee> {
                new Bee("John", 3.2f),
                new Bee("Paul", 2.7f),
                new Bee("George", 1.1f),
                new Bee("Ringo", 2.0f)
            });

            List<Bee> BeesList2 = new List<Bee>();
            BeesList2.AddRange(new List<Bee> {
                new Bee("Kurt",2.3f),
                new Bee("Dave", 7.4f),
                new Bee("Krist", 1.5f),
            });

            Beehive beehive1 = new Beehive(BeesList1);
            Beehive beehive2 = new Beehive(BeesList2);

            //Declare number of days in CollectHoney()
                    
            float amount1 = beehive1.CollectHoney(1);
            float amount2 = beehive1.CollectHoney(2);

            Console.WriteLine(String.Format("The amount of honey collected in Beehive1: {0} Beehive2: {1}", amount1, amount2));

        }
    }
}