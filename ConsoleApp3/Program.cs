using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            //double n = (i*10.0)/7.0 + 1.0*z;
            string[] spørgsmål =
            {
                "Hvad er 5 * 10 ? ",
                "Hvad er 22 * 5 ? ",
                "Hvad hedder far"
            };

            string[] rigtigeSvar =
            {
                "50",
                "110",
                "Supermand"
            };

            int[] points =
            {
                5, //i=0
                7, // i=1
                100
            };
          
            Console.WriteLine("Svar på spørgsmål");
            string svar = "";
            int point = 0;

            for (int i = 0; i < spørgsmål.Length; i = i + 1)
            {
                Console.WriteLine("Spørgsmål nr. " + (i + 1));
                Console.WriteLine(spørgsmål[i]);
                svar = Console.ReadLine();
                if (svar.ToLower() == rigtigeSvar[i].ToLower())
                {
                    point += points[i];
                    Console.WriteLine("Svar er rigtigt.");
                } 
                else
                {
                    point -= 1;
                    Console.WriteLine("Svar er forkert ");
                }
                Console.WriteLine("Du har nu " + point + " points");
                Console.WriteLine("");
            }
            Console.WriteLine("Du er nu færdig med " + point + " points");
            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
