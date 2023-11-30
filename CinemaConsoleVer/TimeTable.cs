using System;
using System.Collections.Generic;
namespace CinemaConsoleVer
{
    public class TimeTable
    {
        private int selectedFilmIndex = 0;

        protected List<string> Cinemas { get => cinemas; set => cinemas = value; }
        protected static List<string> Films { get => films; set => films = value; }
        protected static List<DateTime> SpiderManDates { get; set; }
        protected static List<DateTime> TitanikDates { get; set; }
        protected static List<DateTime> DieHardDates { get; set; }
        protected static List<DateTime> Scream5Dates { get; set; }
        

        static TimeTable()
        {
            Random random = new();
            TimeTable.SpiderManDates = GenerateRandomDates(random);
            TimeTable.TitanikDates = GenerateRandomDates(random);
            TimeTable.DieHardDates = GenerateRandomDates(random);
            TimeTable.Scream5Dates = GenerateRandomDates(random);
        }


        private static List<string> films = new()
        {
            "Человек Паук",
            "Титаник",
            "Крепкий Орешек",
            "Крик(5)",
            "Назад"
        };

        private List<string> cinemas = new()
        {
            "АлаТоо",
            "Россия",
            "Вефа",
            "Плаза",
            "Назад"
        };


        private static List<DateTime> GenerateRandomDates(Random random)
        {
            List<DateTime> dates = new();
            for (int i = 0; i < Films.Count; i++)
            {
                DateTime randomDate = DateTime.Now.AddDays(random.Next(1, 30));
                randomDate = randomDate.AddHours(random.Next(0, 24));
                randomDate = randomDate.AddMinutes(random.Next(0, 60));
                dates.Add(randomDate);
            }
            return dates;
        }
        protected virtual void MoveBack()
        {
            Exit.BackToCinema();
        }

        private void PrintFilms()
        {
            for (int i = 0; i < Films.Count; i++)
            {
                if (i == selectedFilmIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("* " + Films[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("* " + Films[i]);
                }
            }
            Console.WriteLine("*************************************");
        }



        protected virtual void PrintFilmsTimeTable(int numberOfFilm)
        {
            Console.WriteLine($"***********{Films[numberOfFilm]}***********");

            List<DateTime> dates = new();
            switch (numberOfFilm)
            {
                case 0:
                    dates = SpiderManDates;
                    break;
                case 1:
                    dates = TitanikDates;
                    break;
                case 2:
                    dates = DieHardDates;
                    break;
                case 3:
                    dates = Scream5Dates;
                    break;
            }

            for (int i = 0; i < Cinemas.Count - 1; i++)
            {

                Console.WriteLine($" {Cinemas[i]}\n{dates[i]:dd.MM.yyyy HH:mm}\n");
            }
            Console.WriteLine("***************************");
            MoveBack();
        }


        protected virtual void PrintFilmsHeader()
        {
            Console.WriteLine("***********Фильмы***********");
        }


       
        public  void ShowFilms()
        {
            PrintFilmsHeader();
            PrintFilms();
            ConsoleKeyInfo arrow = Console.ReadKey(true);
            Console.Clear();
            if (arrow.Key == ConsoleKey.UpArrow)
            {
                if (selectedFilmIndex > 0)
                {
                    selectedFilmIndex--;
                }
            }
            else if (arrow.Key == ConsoleKey.DownArrow)
            {
                if (selectedFilmIndex < Films.Count - 1)
                {
                    selectedFilmIndex++;
                }
            }
            else if (arrow.Key == ConsoleKey.Enter)
            {
                switch (Films[selectedFilmIndex])
                {
                    case "Человек Паук":
                        PrintFilmsTimeTable(selectedFilmIndex);
                        return;
                    case "Титаник":
                        PrintFilmsTimeTable(selectedFilmIndex);
                        return;
                    case "Крепкий Орешек":
                        PrintFilmsTimeTable(selectedFilmIndex);
                        return;
                    case "Крик(5)":
                        PrintFilmsTimeTable(selectedFilmIndex);
                        return;
                    case "Назад":
                        BackTo();
                        return;
                }
            }
            ShowFilms();
        }
        protected virtual void BackTo()
        {
            Menu.ShowMenu();
        }

    }
}




