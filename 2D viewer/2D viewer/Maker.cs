using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_viewer
{
    internal class Maker
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
        public int z1 { get; set; }
        public int z2 { get; set; }
        public void Write_C(int x1 , int x2 , int y1 , int y2 , int z1 , int z2)
        {
            int x3 , y3 , z3;
            try
            {
                if (x1 > x2 && y1 > y2)
                {
                    x3 = (x1 - x2);
                    y3 = (y1 - y2);
                    z3 = (z1 - z2);
                }
                else if (x2 > x1 && y2 > y1)
                {
                    x3 = (x2 - x1);
                    y3 = (y2 - y1);
                    z3 = (z2 - z1);
                }
                else
                {
                    x3 = y3 = z3 = 0;
                }
                Console.Clear();
                Console.WriteLine("Result Your Shape \n\n");
                if (x1 == -x2 && y1 == -y2 || x2 == -x1 && y2 == -y1) // Cube
                {
                    Console.WriteLine("Cube");
                    for (int j = 0; j < x3; j++)
                    {
                        for (int k = 0; k < y3; k++)
                        {
                            Console.Write("██");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("\n\nWidth : " + y3 + "\nHeight : " + x3 + "\nDepth : " + z3);
                    Console.WriteLine("\nOne face area : " + (x3 * x3) + "\nLateral area : " + 4 * (x3 * x3));
                    Console.WriteLine("\nTotal area : " + 6 * (x3 * x3));
                }
                else if (y2 == 0 || y1 == 0 && x1 == -x2 || x2 == -x1) // Pyramid
                {
                    Console.WriteLine("Pyramid");
                    int n = x3;
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= (n - i); j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k < i * 2; k++)
                        {
                            Console.Write("█");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n\nWidth : " + y3 + "\nHeight : " + x3 + "\nDepth : " + z3);
                    Console.WriteLine("Area : " + 2 * ((y3 * z3) + (x3 * x3)) + "\nVolume : " + x3 * y3);
                }
                else if (y1 == -y2 && x1 == -x2 && x1 >= y1  || x1 <= y1 
                    || y2 == -y1 && x2 == -x1 && x1 >= y1 || x1 <= y1)// Rectangle
                {
                    Console.WriteLine("Rectangle");
                    for (int j = 0; j < x3; j++)
                    {
                        for (int k = 0; k < y3; k++)
                        {
                            Console.Write("█");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("\n\nWidth : " + y3 + "\nHeight : " + x3 + "\nDepth : " + z3);
                    Console.WriteLine("Area : " + (x3 * y3));
                    Console.WriteLine("Volume : " + (x3 * y3 * z3));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
