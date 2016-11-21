using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = 5;
            int rows = 4;
            int width = 3;
            int height = 2;
            string x = "x";
            string o = "o";
            bool flagCol = true;
            bool flagRow = true;

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();

            for (int row = 1; row <= rows; row++)
            {
                if (flagRow == true)
                {
                    for (int h = 1; h <= height; h++)
                    {
                        for (int col = 1; col <= cols; col++)
                        {
                            if (flagCol == true)
                            {
                                for (int xWidth = 1; xWidth <= width; xWidth++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(x);
                                }
                                flagCol = !flagCol;
                            }
                            else
                            {
                                for (int oWidth = 1; oWidth <= width; oWidth++)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(o);
                                }
                                flagCol = !flagCol;
                            }
                        }
                        // Change flag if row starts and ends with same sign
                        if (cols % 2 != 0)
                        {
                            flagCol = !flagCol;
                        }
                        Console.WriteLine();
                    }
                    flagRow = !flagRow;
                    flagCol = true;
                }
                else
                {
                    for (int h = 1; h <= height; h++)
                    {
                        for (int col = 1; col <= cols; col++)
                        {
                            if (flagCol == false)
                            {
                                for (int xWidth = 1; xWidth <= width; xWidth++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write(x);
                                }
                                flagCol = !flagCol;
                            }
                            else
                            {
                                for (int oWidth = 1; oWidth <= width; oWidth++)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(o);
                                }
                                flagCol = !flagCol;
                            }
                        }
                        // Change flag if row starts and ends with same sign
                        if (cols % 2 != 0)
                        {
                            flagCol = !flagCol;
                        }
                        Console.WriteLine();
                    }
                    flagRow = !flagRow;
                    flagCol = true;
                }
            }
            Console.Read();
        }
    }
}
