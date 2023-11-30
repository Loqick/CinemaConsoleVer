using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaConsoleVer
{
    class Exit:BonusMaterial
    {
        static public void FullExit()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            BonusMaterial.CenterText("Спасибо за пользование данным приложением");
            BonusMaterial.CenterText("Поставьте хороший балл если жмот <3");
            Console.ResetColor();
            Console.ReadKey();
            Environment.Exit(0);
        }
        static public void BackToCinema()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Назад");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            TimeTable timetable = new();
            timetable.ShowFilms();

        }
        static public void BackToMenu()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Назад");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Menu.ShowMenu();

        }
        static public void BackToReserv()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Назад");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Reservation reservation = new();
            reservation.ShowReservationMenu();
        }
        static public void BackToReservShowFilm()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Назад");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Reservation reservation = new();
            reservation.ShowFilms();
        }
        static public void BackToPoster()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Назад");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Poster poster = new();
            poster.ShowPoster();
        }

    }
}
