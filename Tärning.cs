using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftOO
{
    class Tärning
    {
        public void kast(int nummer)
        {
            for (int i = 0; i<7; i++)
			{ 
               Random dice = new Random();
               nummer = dice.Next(1, 7);
               Console.WriteLine($"Du kastade tärningen och fick {nummer}.");
			}
           
        }
        
    }
}