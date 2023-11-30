using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaConsoleVer
{
    class Announcement
    {
        private static List<string> newFilms = new()
        {
            "Тачки 12",
            "Счастливы Вместе",
            "Форсаж 91",
            "Гарик Поттер",
            "6 Кадров"
        };

        public static List<string> NewFilms { get => newFilms; set => newFilms = value; }

        public static void ShowAnnouncemet()
        {
            Console.WriteLine("***********Скоро в кино***********");
            foreach (var item in NewFilms)
            {
                if (item != "Счастливы Вместе")
                {
                    Console.WriteLine("\n     ----" + item + "----- \n");
                    Console.WriteLine("**********************************");
                }
                else
                {
                    Console.WriteLine("\n   -----" + item + "----- \n");
                    Console.WriteLine("**********************************");

                }
            }


            Exit.BackToMenu();
        }
    }
}
