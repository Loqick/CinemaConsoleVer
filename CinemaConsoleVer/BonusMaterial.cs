using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CinemaConsoleVer
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Проверка совместимости платформы", Justification = "<Ожидание>")]

    public class BonusMaterial
    {
        private static int initialWindowWidth;
        private static int initialWindowHeight;
        static public void ShowGreetings()
        {
            Console.ReadKey();
            initialWindowWidth = Console.WindowWidth;
            initialWindowHeight = Console.WindowHeight;
            Console.WriteLine();
            Console.WriteLine();
            CenterText("Добро Пожаловать В приложение!!! ");
            Console.WriteLine();
            CenterText("--__-- НЕДО-КИНОТЕАТР--__--");
            Console.WriteLine();
            CenterText("Для управления используйте Стрелочки!!!");
            Thread.Sleep(4000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("ВЫ ГОТОВЫ ??????????");
            Thread.Sleep(2300);
            Console.Clear();

            CenterText("СЕЙЧАС ВЫ УВИДИТЕ ТО, ЧЕГО НИКОГДА НЕ ВИДЕЛИ !!!!!!!");
            Thread.Sleep(3000);

            Console.Clear();

            CenterText("Подготовка к удивительному путешествию...");
            CenterText("   \\o/        \\o/       \\o/        \\o/       \\o/");
            Thread.Sleep(1000);

            CenterText("3");
            Console.Beep(800, 600);
            Thread.Sleep(1000);

            CenterText("2");
            Console.Beep(800, 600);
            Thread.Sleep(1000);

            CenterText("1");
            Console.Beep(800, 600);
            Thread.Sleep(1000);

            CenterText("Да лан шучу");
            Thread.Sleep(1500);
            Console.ResetColor();
            ShowPokemon();
            
        }

        protected static void CenterText(string text)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }


        static void ShowPokemon()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.WriteLine("\t                 .\"-,.__");
            Console.WriteLine("\t                 `.     `.  ,");
            Console.WriteLine("\t              .--'  .._,'\"-' `.");
            Console.WriteLine("\t             .    .'         `'");
            Console.WriteLine("\t             `.   /          ,'");
            Console.WriteLine("\t               `  '--.   ,-\"");
            Console.WriteLine("\t                `\"`   |  \\");
            Console.WriteLine("\t                   -. \\, |");
            Console.WriteLine("\t                    `--Y.'      ___.");
            Console.WriteLine("\t                         \\     L._, \\");
            Console.WriteLine("\t               _.,        `.   <  <\\                _");
            Console.WriteLine("\t             ,' '           `, `.   | \\            ( `");
            Console.WriteLine("\t          ../, `.            `  |    .\\`.           \\ \\_");
            Console.WriteLine("\t         ,' ,..  .           _.,'    ||\\l            )  '\".");
            Console.WriteLine("\t        , ,'   \\           ,'.-.`-._,'  |           .  _._`.");
            Console.WriteLine("\t      ,' /      \\ \\        `' ' `--/   | \\          / /   ..\\");
            Console.WriteLine("\t    .'  /        \\ .         |\\__ - _ ,'` `        / /     `.`.");
            Console.WriteLine("\t    |  '          ..         `-...-\"  |  `-'      / /        . `.");
            Console.WriteLine("\t    | /           |L__           |    |          / /          `. `.");
            Console.WriteLine("\t   , /            .   .          |    |         / /             ` `\\");
            Console.WriteLine("\t  / /          ,. ,`._ `-_       |    |  _   ,-' /               ` \\");
            Console.WriteLine("\t / .           \\\"`_/. `-_ \\_,.  ,'    +-' `-'  _,        ..,-.    \\`.");
            Console.WriteLine("\t.  '         .-f    ,'   `    '.       \\__.---'     _   .'   '     \\ \\");
            Console.WriteLine("\t' /          `.'    l     .' /          \\..      ,_|/   `.  ,'`     L`");
            Console.WriteLine("\t|'      _.-\"\"` `.    \\ _,'  `            \\ `.___`.'\"`-.  , |   |    | \\");
            Console.WriteLine("\t||    ,'      `. `.   '       _,...._        `  |    `/ '  |   '     .|");
            Console.WriteLine("\t||  ,'          `. ;.,.---' ,'       `.   `.. `-'  .-' /_ .'    ;_   ||");
            Console.WriteLine("\t|| '              V      / /           `   | `   ,'   ,' '.    !  `. ||");
            Console.WriteLine("\t||/            _,-------7 '              . |  `-'    l         /    `||");
            Console.WriteLine("\t. |          ,' .-   ,' ||               | .-.        `.      .'     ||");
            Console.WriteLine("\t `'        ,'    `\".'    |               |    `.        '. -.'       `'");
            Console.WriteLine("\t          /      ,'      |               |,'    \\-.._,.'/'");
            Console.WriteLine("\t          .     /        .               .       \\    .''");
            Console.WriteLine("\t        .`.    |         `.             /         :_,'.'");
            Console.WriteLine("\t          \\ `...\\   _     ,'-.        .'         /_.-'");
            Console.WriteLine("\t           `-.__ `,  `'   .  _.>----''.  _  __  /");
            Console.WriteLine("\t                .'        /\"'          |  \"'   '_");
            Console.WriteLine("\t               /_|.-'\\ ,\".             '.'`__'-( \\");
            Console.WriteLine("\t                 / ,\"'\"\\,'               `/  `-.|\" mh");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();
            Console.SetWindowSize(initialWindowWidth, initialWindowHeight);
            Console.SetBufferSize(initialWindowWidth, initialWindowHeight);
        }
    }
}
