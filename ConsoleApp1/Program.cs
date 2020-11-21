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
            IdFunction = Drowing.Rendering(Function[Drowing.Over(IdFunction + delta)].Length, (IdFunction + delta));
            Write(IdFunction);
            Console.ResetColor();
            return IdFunction;
        }

        static void Main()
        {
            int IdFunction = 0;
            ConsoleKeyInfo key;
            for (int i = 0; i < 4; i++)
            {
                Drowing.Rendering(Function[i].Length, i);
                
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Write(IdFunction);
                    Console.ResetColor();
                    continue;
                }
                Write(i);
            }

            while (true)
            {
                key = Console.ReadKey();
                IdFunction = Drowing.Rendering(Function[IdFunction].Length, IdFunction);
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