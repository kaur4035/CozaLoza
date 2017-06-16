using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLoza
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int x = 1; x < 111; x++) {
                if (x % 12 == 0) {
                    Console.WriteLine();
                }
                if (x % 3 == 0 && x % 5 == 0 && x % 7 == 0)
                    Console.WriteLine("cozalozawoza");

                else if (x % 5 == 0 && x % 7 == 0)
                {
                    Console.WriteLine("cozawoza");
                }
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("lozacoza");
                }

                if (x % 3 == 0)
                {
                    Console.WriteLine("coza");

                }
                else {
                    Console.Write(" " + x + " ");
                }


            }
            Console.ReadKey();
        }
    }
    }
        
