using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomTemp = 70;

            Console.WriteLine("hI, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            int currentTemp = Convert.ToInt32(Console.ReadLine());

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temp.");
            } 
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer then room temp");
            }
            else if (roomTemp > currentTemp)
            {
                Console.WriteLine("Colder then room temp");
            }
            else
            {
                Console.WriteLine("Uhmm..... something went wrong");
            }

            Console.ReadLine();













            // ternery 
            //int currentTemp = 80;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "It is room Temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            //ELSE IF 
            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It Is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer then the room temp");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room temp is warmer then current temp");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room Temp.");
            //}
            //Console.ReadLine();

        }
    }
}
