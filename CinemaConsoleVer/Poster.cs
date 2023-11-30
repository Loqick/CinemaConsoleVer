using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaConsoleVer
{
    class Poster : TimeTable
    {
        static Poster()
        {
            Grade = GenerateRandomGrade();
        }

        private static List<int> Grade { get; set; }
      

        private static int  numberOfFilm = 0;


        private static void PrintFilms()
        {
            int maxTitleLength = Films.Max(film => film.Length) + 2;

            for (int i = 0; i < Films.Count; i++)
            {
                if (Films[i] != "Назад")
                {
                    if (i == numberOfFilm)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"* {Films[i]}".PadRight(maxTitleLength)+$" Оценка({ Grade[i]})\n");
                        Console.ResetColor();

                        
                    }
                    else
                        Console.Write($"* {Films[i]}".PadRight(maxTitleLength) + $" Оценка({ Grade[i]})\n");
                }
                else
                {
                    if (i == numberOfFilm)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"* {Films[i]}".PadRight(maxTitleLength));
                       
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.Write($"* {Films[i]}".PadRight(maxTitleLength));
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("*************************************");
        }




        protected override void PrintFilmsHeader()
        {
            Console.WriteLine("***********Афиша***********\n");
        }

        public void ShowPoster()
        {
            PrintFilmsHeader();
            PrintFilms();
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
                if (numberOfFilm < Films.Count - 1)
                {
                    numberOfFilm++;
                }
            }
            else if (arrow.Key == ConsoleKey.Enter)
            {
                switch (Films[numberOfFilm])
                {
                    case "Человек Паук":
                        DescriptionSpiderMan();
                        Exit.BackToPoster();
                        return;
                    case "Титаник":
                        DescriptionTitanic();
                        Exit.BackToPoster();
                        return;
                    case "Крепкий Орешек":
                        DescriptionDieHard();
                        Exit.BackToPoster();
                        return;
                    case "Крик(5)":
                        DescriptionScream5();
                        Exit.BackToPoster();
                        return;
                    case "Назад":
                        BackTo();
                        return;
                }
            }
            ShowPoster();
        }

        static private List<int> GenerateRandomGrade()
        {
            List<int> RandomGrade = new();
            Random random = new();


            for (int i = 0; i < Films.Count; i++)
            {
                RandomGrade.Add(random.Next(3, 5));
            }
            return RandomGrade;
        }
        static void DescriptionSpiderMan()
        {
            Console.WriteLine("***************************************Человек Паук***************************************");
            Console.WriteLine();
            Console.WriteLine("Питер Паркер – обыкновенный школьник. Однажды он отправился с классом на экскурсию,\nгде его кусает странный паук-мутант.");
            Console.WriteLine();
            Console.WriteLine("Через время парень почувствовал в себе нечеловеческую силу и ловкость в движении,\nа главное – умение лазать по стенам и метать стальную паутину.");
            Console.WriteLine();
            Console.WriteLine("Свои способности он направляет на защиту слабых.\nТак Питер становится настоящим супергероем по имени Человек-паук, который помогает людям и борется с преступностью.");
            Console.WriteLine();
            Console.WriteLine("Но там, где есть супергерой, рано или поздно всегда объявляется и суперзлодей...");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine();
        }
        static void DescriptionTitanic()
        {
            Console.WriteLine("****************************************Титаник*****************************************");
            Console.WriteLine();
            Console.WriteLine("История любви между Джеком и Розой, двумя представителями разных социальных классов,\nразгорается на фоне гибели легендарного парохода «Титаник».");
            Console.WriteLine();
            Console.WriteLine("Хотя они не могут быть вместе в жизни, их любовь оставляет неизгладимый след\n и дает им силу для выживания в самых трудных обстоятельствах.");
            Console.WriteLine();
            Console.WriteLine("Титаник – это история о любви, потерях и силе духа,\nкоторая оставит неповторимый след в сердцах зрителей.");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine();
        }
        static void DescriptionDieHard()
        {
            Console.WriteLine("**************************************Крепкий орешек**************************************");
            Console.WriteLine();
            Console.WriteLine("Нью-Йорк. Рождество. На одной из вечеринок в здании Накатоми Плаза происходит вооруженное нападение.\nБывший полицейский Джон Макклейн становится неудачливым героем,\nкоторый в одиночку сражается с террористами,захватившими здание.\nЕму предстоит не только спасти заложников, но и воссоединиться со своей семьей.");
            Console.WriteLine();
            Console.WriteLine("Этот фильм о приключениях Джона Макклейна стал классикой боевиков и\nпринес бессмертную реплику: «Да здравствует крепкий орешек!».");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine();
        }
        static void DescriptionScream5()
        {
            Console.WriteLine("*****************************************Крик 5*****************************************");
            Console.WriteLine();
            Console.WriteLine("После долгого перерыва в городке Вудсборо происходит новая серия загадочных убийств,\nсвязанных с таинственным маньяком в маске Гостфейса. Сидни Прескот,\nединственная выжившая из предыдущих событий,\nвозвращается, чтобы защитить свою семью и раскрыть тайны прошлого.");
            Console.WriteLine();
            Console.WriteLine("Фильм продолжает традиции хоррор-саги, известной своими неожиданными поворотами\nи обильными отсылками к жанру ужасов.");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine();
        }



    }
}
