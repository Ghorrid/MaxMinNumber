using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinNumber
{
    internal class Program
    {
            static void Main(string[] args)
            {

                Console.WriteLine("Podaj liczby oddzielone spacją, a wskaże Ci maksymalną i minimalną:");

                string userInput = Console.ReadLine();

                Console.WriteLine(GiveMaxMin(userInput));

                Console.ReadKey();
            }

            static string GiveMaxMin(string s)
            {
                string[] sarr = s.Split(' ');
                int min = 0;
                int max = 0;

                for (int i = 0; i < sarr.Length; i++)
                {
                    int number = int.Parse(sarr[i]);
                    if (number > max) { max = number; }

                    if (i == 0) { min = number; }
                    else if (number < min) { min = number; }
                }

                return $"Max: {max}, min: {min}.";
            }
        }
    }