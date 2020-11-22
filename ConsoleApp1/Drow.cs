using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FeelWords
{
    class DrowingMenu
    {
        private static int Overflow(int e)
        {
            int g = 0;
            if (e < 0)
            {
                g = Program.Function.Length - 1;
            }
            if (e > Program.Function.Length - 1 && e != 0) {
                g = e % 4;
            }
            if (e > -1 && e < Program.Function.Length)
            {
                g = e;
            }
            return g;
        }
        public static int Over(int x)
        {
            return Overflow(x);
        }

        private static int CenteringPositionCalculation()
        {
            int z;
            z = Console.WindowWidth;
            return z;
        }

        public static int Rendering( int LengthNameFunction, int IdFunction)
        {
            int y = Overflow(IdFunction);
            int x = (CenteringPositionCalculation() / 2) - (LengthNameFunction/2);
            Drow.WritePositionElement(x, y);
            return y;
        }
    }
}
