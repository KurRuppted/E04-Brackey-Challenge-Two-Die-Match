using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random numberGen01 = new Random();
            Random numberGen02 = new Random();

            int roll01 = 2;
            int roll02 = 1;
            int attempts = 0; 

            Console.WriteLine("Press enter to roll the two dices!");

            while(roll01  != roll02)
            {   
                Console.ReadKey();

                roll01 = numberGen01.Next(1,7); 
                roll02 = numberGen02.Next(1,7); 
                Console.WriteLine("Die 1: " + roll01);
                Console.WriteLine("Die 2: " + roll02);
                attempts ++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to match both dies!");
            


            Console.ReadKey();
        }
    }
}
