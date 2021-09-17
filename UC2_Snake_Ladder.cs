using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Assignment_Snake_Ladder
{
    public class UC2_Snake_Ladder
    {

        public static void RandomNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 6);
            Console.WriteLine("the Random number between 0 to 6 is " +
           number);
            Console.ReadKey();
        }
    }
}           
