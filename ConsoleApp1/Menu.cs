using System;

namespace FeelWords
{
	class ConsoleWrite//Menu
	{
		public static void NewGame()
		{
			Console.WriteLine(Program.Function[0]);//ga
		}
		public static void Continue()
		{
			Console.WriteLine(Program.Function[1]);
		}
		public static void Rating()
		{
			Console.WriteLine(Program.Function[2]);
		}//рейтинг
		public static void Exit()
        {
			Console.WriteLine(Program.Function[3]);
        }
	}
}
