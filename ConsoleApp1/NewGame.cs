using System;
using System.Collections.Generic;
using System.Text;

namespace FeelWords
{
    class NewGame
    {
        private static string AskPlayerName()
        {
            Console.WriteLine("Введите ваш ник-нейм:");
            return Console.ReadLine();
        }
        public static void NewGames()
        {
            Console.Clear();
            string PlayerName = AskPlayerName();
            Console.WriteLine("Остальной функционал не подвезли :(");
        }
    }
}
