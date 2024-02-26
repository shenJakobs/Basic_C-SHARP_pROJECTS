using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple Program
            //    Console.WriteLine("Whats your name?");
            //    string yourName = Console.ReadLine(); 
            //    Console.WriteLine("Your name is: " + yourName);
            //    Console.ReadLine(); 
            //}

            //CASTING STRING TO INTEGER 
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your Favorite Number plus 5 is: " + total);
            //Console.ReadLine();

            //DATA TYPES
            //    bool isStudying = fales;
            //    byte hoursWorker = 42;
            //    sbyte currentTemp = -23;
            //    char questionMark = '\u2013';

            //    decimal moneyInBank = 100.5m;

            //    double heightInCentimeters = 211.30202092;

            //    float secondsLeft = 2.62f;

            //    short tempOnMars = -341;

            //    string myName = 'Shen'
            //

            int currentAge = 30; // integer to string casting
            string yearsOld = currentAge.ToString();

            bool isRaining = true; // bool to string casting 
            string rainingStatus = Convert.ToString(isRaining);



        }
    }
}
