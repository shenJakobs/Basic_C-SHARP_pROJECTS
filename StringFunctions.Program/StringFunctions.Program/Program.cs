using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Shen";
            string qoute = "The man said, \"Hello\", Shen. \n Hello on a new line. \n \t Hello on a tab.";
            string FileName = @"C:\User\Shen";

            bool TrueOrFales = name.Contains("s");
            TrueOrFales = name.EndsWith("s");

            int length = name.Length;


            Console.WriteLine(qoute);
            Console.ReadLine();



        }
    }
}
