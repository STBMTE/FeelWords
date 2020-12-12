using System;
using System.Collections.Generic;
using System.Text;

namespace FeelWords
{
    class FillingInTheArrayField//filling in the array 
    {
        private static string rightthetopcorner = "┌";
        private static string thetopitersection = "┬";
        private static string leftthetopcorner = "┐";
        private static string rigthcentersection = "├";
        private static string centersection = "┼";
        private static string leftthecentersection = "┤";
        private static string rigthbottomcross = "└";
        private static string centerbottomsection = "┴";
        private static string leftbottomcross = "┘";
        private static string verticalbar = "│";
        private static string horizontalbar = "─";
        private static bool BoundaryElements(int a)
        {
            return ((a % 4) == 0);
        }

        
        public static void FillingField(int a, int b)// a - Ox; b - Oy;
        {
            int rt = 0;
            var SymbolArray = new string[a * 4 + 1, b * 4 + 1];
            Console.Clear();
            for (int i = 0; i <= a * 4; i++)// i - Ox;
            {
                for (int j = 0; j <= b*4; j++) // j - Oy
                {
                    if (BoundaryElements(i) && j == 0 && i != 0)
                    {
                        SymbolArray[i, j] = thetopitersection;
                    }
                    if (BoundaryElements(i) && j != 0 && ((j % 4) != 0))
                    {
                        SymbolArray[i, j] = verticalbar;
                    }
                    if (BoundaryElements(i) && j != 0 && BoundaryElements(j))
                    {
                        SymbolArray[i, j] = centersection;
                    }
                    if (BoundaryElements(j) && j != 0 && i == 0)
                    {
                        SymbolArray[i, j] = rigthcentersection;
                    }
                    if (BoundaryElements(j) && j != 0 && i == a * 4)
                    {
                        SymbolArray[i, j] = leftthecentersection;
                    }
                    if ((((j == 0) || (j == b * 4)) && i != 0 && i != a * 4 && (i % 4) != 0) || (i != 0 && (i % 4) != 0 && (j % 4) == 0))
                    {
                        SymbolArray[i, j] = horizontalbar;
                    }
                    if ((j == b * 4) && (i % 4) == 0)
                    {
                        SymbolArray[i, j] = centerbottomsection;
                    }
                }
            }

            SymbolArray[0, 0] = rightthetopcorner;
            SymbolArray[0, b*4] = rigthbottomcross;
            SymbolArray[a*4, 0] = leftthetopcorner;
            SymbolArray[a*4, b*4] = leftbottomcross;

            for (int i = 0; i <= a * 4; i++)
            {
                for (int j = 0; j <= b * 4; j++)
                {
                    Console.SetCursorPosition(i, j);
                    
                    if (i % 2 == 0 && j % 2 == 0 && i % 4 != 0 && j % 4 != 0)
                    {
                        ++rt;
                        SymbolArray[i, j] = Convert.ToString(rt);
                    }
                    Console.WriteLine(SymbolArray[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
