using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaConsoleVer
{
    public class Reservation : TimeTable
    {
        private static List<string> reservFilm = new();
        private static List<string> reservCinema = new();
        private static List<DateTime> reservDate = new();

        static Reservation()
        {
            ReservFilm = new List<string>();
            ReservCinema = new List<string>();
            ReservDate = new List<DateTime>();
        }

        private int numberOfFilm;
        private int numberOfCinema;

        private enum ReservMenuItem
        {
            Забронировать = 1,
            Ваша_Бронь = 2,
            Назад = 3
        }

        ReservMenuItem numberOfMenuItem = ReservMenuItem.Забронировать;

        public static List<string> ReservFilm { get => reservFilm; set => reservFilm = value; }
        public static List<string> ReservCinema { get => reservCinema; set => reservCinema = value; }
        public static List<DateTime> ReservDate { get => reservDate; set => reservDate = value; }

        private static void PrintReservation(ReservMenuItem selectedMenuItem)
        {
            Console.WriteLine("***********Бронь***********");
            foreach (var item in Enum.GetValues(typeof(ReservMenuItem)))
            {
                if (item.Equals(selectedMenuItem))
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

            Console.WriteLine("***************************");

        }

        public void ShowReservationMenu()
        {
            PrintReservation(numberOfMenuItem);
            ConsoleKeyInfo arrow = Console.ReadKey(true);
            Console.Clear();

            if (arrow.Key == ConsoleKey.UpArrow)
            {
                if (numberOfMenuItem > ReservMenuItem.Забронировать)
                {
                    numberOfMenuItem--;
                }
            }
            else if (arrow.Key == ConsoleKey.DownArrow)
            {
                if (numberOfMenuItem < ReservMenuItem.Назад)
                {
                    numberOfMenuItem++;
                }
            }
            else if (arrow.Key == ConsoleKey.Enter)
            {
                switch (numberOfMenuItem)
                {
                    case ReservMenuItem.Забронировать:
                        ShowFilms();
                        return;
                    case ReservMenuItem.Ваша_Бронь:
                        PrintYourReservation();
                        break;
                    case ReservMenuItem.Назад:
                        Menu.ShowMenu();
                        return;
                }
            }
            ShowReservationMenu();
        }

        protected override void PrintFilmsHeader()
        {
            Console.WriteLine("*********** Выбирите Фильм***********");
        }

        protected override void BackTo()
        {

            ShowReservationMenu();
        }

        private int PrintCinemas(int numberOfSession)
        {
            List<DateTime> dates = new();
            Console.WriteLine($"***********{Films[numberOfSession]}***********");
            switch (numberOfSession)
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

            for (int i = 0; i < Cinemas.Count; i++)
            {
                if (i == numberOfFilm)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($" {Cinemas[i]}");

                    if (Cinemas[i] != "Назад")
                    {
                        Console.WriteLine($"{dates[i]:dd.MM.yyyy HH:mm}\n");
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($" {Cinemas[i]}");

                    if (Cinemas[i] != "Назад")
                    {
                        Console.WriteLine($"{dates[i]:dd.MM.yyyy HH:mm}\n");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("********************************");
            }

            return numberOfFilm;
        }

        protected override void PrintFilmsTimeTable(int numberOFfilm)
        {
            numberOfFilm = PrintCinemas(numberOFfilm);
            ConsoleKeyInfo arrow = Console.ReadKey(true);
            Console.Clear();

            if (arrow.Key == ConsoleKey.UpArrow)
            {
                if (numberOfFilm > 0)
                {
                    numberOfFilm--;
                }
            }
            else if (arrow.Key == ConsoleKey.DownArrow)
            {
                if (numberOfFilm < Cinemas.Count - 1)
                {
                    numberOfFilm++;
                }
            }
            else if (arrow.Key == ConsoleKey.Enter)
            {

                switch (Cinemas[numberOfFilm])
                {
                    case "АлаТоо":
                        numberOfCinema = 0;
                        PrintReservFilmSession(numberOFfilm, numberOfCinema);
                        return;
                    case "Россия":
                        numberOfCinema = 1;
                        PrintReservFilmSession(numberOFfilm, numberOfCinema);
                        return;
                    case "Вефа":
                        numberOfCinema = 2;
                        PrintReservFilmSession(numberOFfilm, numberOfCinema);
                        return;
                    case "Плаза":
                        numberOfCinema = 3;
                        PrintReservFilmSession(numberOFfilm, numberOfCinema);
                        return;
                    case "Назад":
                        ShowFilms();
                        return;
                }
            }

            PrintFilmsTimeTable(numberOFfilm);
        }


        private void PrintReservFilmSession(int numberOfFilm, int numberOfCinema)
        {

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
            if (ReservFilm.Contains(Films[numberOfFilm]) && ReservCinema.Contains(Cinemas[numberOfCinema]))
            {
                Console.Clear();
                Console.WriteLine("***********************************");
                Console.WriteLine();
                Console.WriteLine(" Вы уже забронировали данный сеанс");
                Console.WriteLine();
                Console.WriteLine("***********************************");
                Exit.BackToReservShowFilm();


            }

            ReservFilm.Add(Films[numberOfFilm]);
            ReservCinema.Add(Cinemas[numberOfCinema]);
            ReservDate.Add(dates[numberOfCinema]);
            Console.WriteLine("***********Вы Забронировали***********");
            Console.WriteLine($"\n {Films[numberOfFilm]} " +
            $"\n {Cinemas[numberOfCinema]}\n {dates[numberOfCinema]:dd.MM.yyyy HH:mm}\n");
            Console.WriteLine("**************************************");
            Exit.BackToReservShowFilm();
        }
      
        private void PrintYourReservation()
        {
            Console.Clear();
            Console.WriteLine("***************Ваша Бронь*******************\n");

            if (ReservFilm.Count == 0)
            {
                Console.WriteLine("\tУ вас нет активных броней.\n");
                Console.WriteLine("********************************************");
                Exit.BackToReserv();
            }
            for (int i = 0; i < ReservFilm.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {ReservCinema[i]} / {ReservFilm[i]} / {ReservDate[i]:dd.MM.yyyy HH:mm}\n");
                Console.WriteLine("********************************************");

            }

            Console.WriteLine("     Введите число брони для ее отмены\n");
            Console.WriteLine($"{ReservFilm.Count + 1}) Назад");

            if (int.TryParse(Console.ReadLine(), out int selectedReservNumber) && selectedReservNumber >= 1 && selectedReservNumber <= ReservFilm.Count + 1)
            {
                if (selectedReservNumber == ReservFilm.Count + 1)
                {
                    Console.Clear();
                    ShowReservationMenu();
                }
                else
                {
                    ReservFilm.RemoveAt(selectedReservNumber - 1);
                    ReservCinema.RemoveAt(selectedReservNumber - 1);
                    ReservDate.RemoveAt(selectedReservNumber - 1);

                    Console.Clear();
                    Console.WriteLine("***********************************\n");
                    Console.WriteLine("Бронь успешно отменена.\n");
                    Console.WriteLine("***********************************");
                    Console.ReadKey();
                    Console.Clear();
                    ShowReservationMenu();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("***********************************\n");
                Console.WriteLine("Неверный ввод. Пожалуйста, попробуйте еще раз.");
                Console.WriteLine("***********************************\n");
                Console.ReadKey();
                PrintYourReservation();
            }
        }

    }
}







