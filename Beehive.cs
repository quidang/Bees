using System;
using System.Collections.Generic;

namespace Program
{
   public class Beehive 
    {   
        List<Bee> Bees;

        public Beehive(List<Bee> bees) 
        {
            this.Bees = bees;
        }

        public float CollectHoney(int days) {
            float amount = 0.0f;

            foreach (Bee bee in Bees)
            {
                amount =+ days * bee.size * 0.2f;
            }
            
            return amount;
        }
    }     
}

// Create a method that requires number of days, bee sizes and list of bees. To return amount of honey collected.