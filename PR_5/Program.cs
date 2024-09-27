//*************************************/
//* Практическая работа №4            */
//* Выполнила: Корнеева В.Е.,3 2-ИСП  */
//* Задание:                          */
//*************************************/
using System;

namespace PR_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Практическая работа №5";
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Салют!");
                Console.Write("Введите переменную дискриминанта a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную дискриминанта b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную дискриминанта c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                // Проверка для случаев, когда b и c равны 0
                if (c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: значения b или c не могут быть одновременно равны нулю.");
                    Console.ReadKey();
                    return;
                }
                else if (b == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: значение b не может быть равно нулю.");
                    Console.ReadKey();
                    return;
                }
                double d = Math.Pow(b, 2) - (4 * a * c);
                if (d < 0)
                {
                    d = d * -1;
                    double x1 = (-b/2*a);
                    double x11 = (Math.Sqrt(d)/2);
                    double x2 = (-b / 2 * a);
                    double x21 = Math.Sqrt(d)/2;
                    Console.WriteLine($"Ваш результат имеет два комлпексных корня: {x1} + {x11}i , {x2} - {x21}i");
                }
                else if (d == 0)
                {
                    Console.WriteLine("Дискриминант равен нулю");
                    double x = -b / (2 * a);
                    Console.WriteLine($"Вот вам и результат: {x}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Дискриминант положительный");
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Ваш результат имеет два корня: {x1} и {x2}");
                }
            }
            catch (FormatException fx) // частные исключения
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы что-то не так сделали... \nОшибка: " + fx.Message);
            }
            catch (Exception e) // общие исключения
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что-то пошло не так... \tОшибка: " + e.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}