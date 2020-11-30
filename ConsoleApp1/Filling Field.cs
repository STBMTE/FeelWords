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
            return ((a % 2) == 0);
        }

        public static void FillingField(int a, int b)// a - Ox; b - Oy;
        {
            var SymbolArray = new string[a * 2 + 1, b * 2 + 1];

            for (int i = 0; i <= a*2; i++)// i - Ox;
            {
                for (int j = 0; j <= b*2; j++) // j - Oy
                {
                    if(BoundaryElements(i) && j == 0 && i != 0)
                    {
                        SymbolArray[i,j] = thetopitersection;
                    }
                    if(BoundaryElements(i) && j != 0 && ((j % 2) != 0))
                    {
                        SymbolArray[i, j] = verticalbar;
                    }
                    if(BoundaryElements(i) && j != 0 && BoundaryElements(j))
                    {
                        SymbolArray[i, j] = centersection;
                    }
                    if (BoundaryElements(j) && j != 0 && i == 0)
                    {
                        SymbolArray[i, j] = rigthcentersection;
                    }
                    if (BoundaryElements(j) && j != 0 && i == a * 2)
                    {
                        SymbolArray[i, j] = leftthecentersection;
                    }
                    if ((((j == 0) || (j == b * 2)) && i != 0 && i != a * 2 && (i % 2) != 0) || ( i != 0 && (i % 2) != 0 && (j % 2) == 0))
                    {
                        SymbolArray[i, j] = horizontalbar;
                    }
                    if ((j == b * 2) && (i % 2) == 0)
                    {
                        SymbolArray[i, j] = centerbottomsection;
                    } 
                }
            }

            SymbolArray[0, 0] = rightthetopcorner;
            SymbolArray[0, b*2] = rigthbottomcross;
            SymbolArray[a*2, 0] = leftthetopcorner;
            SymbolArray[a*2, b*2] = leftbottomcross;

            for (int i = 0; i <= a * 2; i++)
            {
                for (int j = 0; j <= b * 2; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(SymbolArray[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
