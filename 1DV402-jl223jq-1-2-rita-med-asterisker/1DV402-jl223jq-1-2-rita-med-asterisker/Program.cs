using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte asterisk = 1;
            
            for (int row = 0; row <= 26; row++)
            {
                //Ger färg till asterisken
                switch (asterisk)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        asterisk++;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        asterisk++;
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        asterisk = 1; // Återställer "asterisk" till sitt ursprungliga värde
                        break;
                }
                //Ser till att det görs ett mellanrum i början av varannan rad
                if (row % 2 != 0)
                {
                    Console.Write(" ");
                }
                //Skriver ut asterisker och mellanrum
                for (int col = 0; col < 39; col++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                // Gör ny rad och återställer färgen
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}
