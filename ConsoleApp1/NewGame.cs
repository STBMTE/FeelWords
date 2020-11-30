using System;
using System.Collections.Generic;
using System.Text;

namespace FeelWords
{
    class Drow 
    {
        public static void WritePositionElement(int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
            }
            catch
            {
                Console.SetCursorPosition(Console.WindowWidth - 15, Console.WindowHeight - 15);
                Console.WriteLine("Вышел за пределы буфера");
            }
        }
    }
    class Field
    {
        public int width;
        public int higth;
    }
    class NewGame
    {
        private static int Read(int i)
        {
            int z = 0;
            int j = 0;
            switch (i)
            {
                case 1:
                    j = Console.BufferWidth;
                    Console.WriteLine("Введите ширину игрового поля, но не больше {0}", j/5);
                    break;
                case 2:
                    j = Console.BufferHeight;
                    Console.WriteLine("Введите высоту игрового поля, но не больше {0}", j/5);
                    break;
            }
            while (true)
            {
                try
                {
                    z = Convert.ToInt32(Console.ReadLine());
                    if (z >= 0 && z <= j / 5)
                    {
                        return z;
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение");
                    }
                }
                catch
                {
                    Console.WriteLine("Введено не число");
                }

            }
        }
        private static string AskPlayerName()
        {
            Console.WriteLine("Введите ваш ник-нейм:");
            return Console.ReadLine();
        }
        public static void NewGames()
        {
            
            Field Fields = new Field();
            Console.Clear();
            string PlayerName = AskPlayerName();
            Fields.width = Read(1);
            Fields.higth = Read(2);
            FillingInTheArrayField.FillingField(Fields.width, Fields.higth);
        }
    }
}
