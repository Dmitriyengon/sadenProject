using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Помогу подобрать тебе фильм!");
            Console.WriteLine("Как вас зовут?");

            String name = Console.ReadLine();

            Console.WriteLine("Здраствуйте " + name );

            Console.WriteLine("Фильм какого жанра вы хотели бы посмотреть: комедия, драма, фантастика, эротика");

            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае рекомендую вам посмототреть:");

            if (genre == "комедия")
            {
                Console.WriteLine("РЭД 2");
                Console.WriteLine("Тупой и еще тупее");
                Console.WriteLine("Альянс");

            }
            else if (genre == "фантастика")

            {
                Console.WriteLine("Люди Икс");
                Console.WriteLine("Черепашка ниндзя");
            }
            else if (genre == "эротика")
            {
                Console.WriteLine("Сколько вам лет?");

                String YearString = Console.ReadLine();

                int years = Int32.Parse(YearString);
                if (years < 18)

                {
                    Console.WriteLine("К сожалению данный Жанр доступен только для 18+.");
                    Console.WriteLine("Приходите через " + (18-years) + " лет");
                }
                else
                {
                    Console.WriteLine("Нимфоманка");
                    Console.WriteLine("Эндорфин");
                }
            }
            else
            {
                Console.WriteLine("Слезы");
                Console.WriteLine("Грезы");
                Console.WriteLine("Проект");

            }
            Console.ReadLine();
        }
    }
}

