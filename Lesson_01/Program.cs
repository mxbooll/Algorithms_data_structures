// Смирнов Максим
using System;

namespace Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sel = 0;
            do
            {
                Menu();
                int.TryParse(Console.ReadLine(), out sel);
                switch (sel)
                {
                    case 1:
                        Solution1();
                        break;
                    case 2:
                        Solution2();
                        break;
                    case 3:
                        Solution3();
                        break;
                    case 4:
                        Solution4();
                        break;
                    case 0:
                        Console.WriteLine("Bye-bye");
                        break;
                    default:
                        Console.WriteLine("Wrong selected\n");
                        break;
                }
            } while (sel != 0);
        }

        private static void Menu()
        {
            Console.WriteLine("1 - task1\n ");
            Console.WriteLine("2 - task2\n ");
            Console.WriteLine("3 - task3\n ");
            Console.WriteLine("4 - task4\n ");
            Console.WriteLine("0 - exit\n ");
        }

        // Индекс массы тела
        static void Solution1()
        {
            Console.WriteLine("Solution1\n");
            double height;
            double weight;
            double index;

            Console.Write("Enter person height (in meters): ");
            double.TryParse(Console.ReadLine(), out height);

            Console.Write("Enter person weight (in kilograms): ");
            double.TryParse(Console.ReadLine(), out weight);

            index = weight / (height * height);
            Console.Write($"Body mass index equals: {index}\n");
        }

        // Максимальное из 4 чисел
        static void Solution2()
        {
            Console.WriteLine("Solution2\n");
            int first, second, third, fourth;
            int max;

            Console.Write("Enter four numbers via a space: ");
            var input = Console.ReadLine().Split();

            int.TryParse(input[0], out first);
            int.TryParse(input[1], out second);
            int.TryParse(input[2], out third);
            int.TryParse(input[3], out fourth);

            max = first;
            if (second > max)
            {
                max = second;
            }
            if (third > max)
            {
                max = third;
            }
            if (fourth > max)
            {
                max = fourth;
            }
            Console.Write($"Max number: {max}\n");
        }

        // Обмен значениями двух целочисленных переменных
        static void Solution3()
        {
            Console.WriteLine("Solution3\n");
            int first = 3;
            int second = 7;

            Console.WriteLine($"first = {first} second = {second}");
            Console.WriteLine("swap");

            first = first + second;
            second = first - second;
            first = first - second;

            Console.WriteLine($"first = {first} second = {second}");

        }

        // Корни квадратного уравнения
        static void Solution4()
        {
            Console.WriteLine("Solution4\n");
            int a, b, c;
            double D, x1, x2;
            Console.Write("Enter koefficients a, b, c: ");
            var input = Console.ReadLine().Split();

            int.TryParse(input[0], out a);
            int.TryParse(input[1], out b);
            int.TryParse(input[2], out c);

            if (a == 0)
            {
                Console.Write("This is not a quadratic equation\n");
                return;
            }
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.Write("No roots\n");
                return;
            }
            x1 = (-b + Math.Sqrt(D)) / 2 * a;
            x2 = (-b - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
    }
}
