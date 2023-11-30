using System;

namespace CinemaConsoleVer
{
    public static class Menu
    {
        private enum MenuItem
        {
            Афиша = 1,
            Анонс = 2,
            Бронь = 3,
            Рассписание = 4,
            Выход = 5
        }

        private static void PrintMenu(MenuItem numberOfMenuItem)
        {
            Console.WriteLine("***********MENU***********");
            foreach (var item in Enum.GetValues(typeof(MenuItem)))
            {
                if (item.Equals(numberOfMenuItem))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("* " + item);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("* " + item);
                }
            }

            Console.WriteLine("**************************");

        }

        static MenuItem numberOfMenuItem = MenuItem.Афиша;

        public static void ShowMenu()
        {

            PrintMenu(numberOfMenuItem);
            ConsoleKeyInfo arrow = Console.ReadKey(true);
            Console.Clear();
            if (arrow.Key == ConsoleKey.UpArrow)
            {
                if (numberOfMenuItem > MenuItem.Афиша)
                {
                    numberOfMenuItem--;
                }
            }
            else if (arrow.Key == ConsoleKey.DownArrow)
            {
                if (numberOfMenuItem < MenuItem.Выход)
                {
                    numberOfMenuItem++;
                }
            }
            else if (arrow.Key == ConsoleKey.Enter)
            {
                switch (numberOfMenuItem)
                {
                    case MenuItem.Выход:
                        {
                            Exit.FullExit();
                            return;
                        }
                    case MenuItem.Анонс:
                        {
                            Announcement.ShowAnnouncemet();
                            return;
                        }
                    case MenuItem.Афиша:
                        {
                            Poster poster = new();
                            poster.ShowPoster();
                            return;
                        }
                    case MenuItem.Бронь:
                        {
                            Reservation reserv = new();
                            reserv.ShowReservationMenu();
                            return;
                        }
                    case MenuItem.Рассписание:
                        {

                            TimeTable timeTable = new();
                            timeTable.ShowFilms();
                            return;
                        }
                }
            }
            ShowMenu();
        }
    }
}
