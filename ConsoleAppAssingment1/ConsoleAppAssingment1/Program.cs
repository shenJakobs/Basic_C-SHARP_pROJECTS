using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssingment1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
                // Defining an array of string
                string[] stringsArray = new string[3]; 

                //  input some text
                Console.WriteLine("What is your name:");
                string userInput = Console.ReadLine();

                // Loop through each string in the array and append user input to it
                for (int i = 0; i < stringsArray.Length; i++)
                {
                    stringsArray[i] += userInput;
                }

                // Loop to print each string in the array
                Console.WriteLine("Updated array elements:");
                foreach (string str in stringsArray)
                {
                    Console.WriteLine(str);
                Console.ReadLine();
                }
            }
    }
}
