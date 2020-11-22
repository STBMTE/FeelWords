using System;

namespace FeelWords
{
    
    class Program
    {
        
        public static string[] Function = new string[4] {"NEW GAME", "CONTINUE", "RATING", "EXIT"};
        public static void Write(int i)
        {
            Console.WriteLine(Function[i]);
        }

        public static int Redrawing(int IdFunction, int delta = 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            IdFunction = DrowingMenu.Rendering(Function[DrowingMenu.Over(IdFunction + delta)].Length, (IdFunction + delta));
            Write(IdFunction);
            Console.ResetColor();
            return IdFunction;
        }

        public static void MenuPoint()
        {
            int IdFunction = 0;
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                DrowingMenu.Rendering(Function[i].Length, i);

                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Write(IdFunction);
                    Console.ResetColor();
                    continue;
                }
                Write(i);
            }
        }

        public static void Main()
        {
            int IdFunction = 0;
            ConsoleKeyInfo key;
            MenuPoint();
            while (true)
            {
                key = Console.ReadKey();
                IdFunction = DrowingMenu.Rendering(Function[IdFunction].Length, IdFunction);
                Write(IdFunction);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        IdFunction = Redrawing(IdFunction, 1);
                        break;
                    case ConsoleKey.S:
                        IdFunction = Redrawing(IdFunction, 1);
                        break;
                    case ConsoleKey.UpArrow:
                        IdFunction = Redrawing(IdFunction, -1);
                        break;
                    case ConsoleKey.W:
                        IdFunction = Redrawing(IdFunction, -1);
                        break;
                    case ConsoleKey.Enter:
                        FunctionCall.FunctionCalling(IdFunction);
                        break;
                }
            }
        }
    }

    class FunctionCall 
    {
        public static void FunctionCalling(int IdFunction)
        {
            switch (IdFunction) 
            {
                case 0:
                    NewGame.NewGames();
                    Console.Clear();
                    Program.Main();
                    break;/*
                case 1:
                    Continues.Continue();
                    break;
                case 2:
                    Resalt.Resalts();
                    break;*/
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}