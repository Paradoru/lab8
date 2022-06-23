using System;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                matrosov.number nikita;
                Console.WriteLine("Введите первое число:");
                nikita.first = double.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Введите второе число:");
                    nikita.second = double.Parse(Console.ReadLine());
                    try
                    {
                        if (nikita.second == 0)
                        {
                            throw new Exception("На 0 делить нельзя");
                        }
                        else
                        {
                            double a = nikita.first /= nikita.second;
                            Console.WriteLine($"{a:F2}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (nikita.second == 0);
            }
            catch
            {
                Console.WriteLine("Пожалуйста, вводите только цифры");
            }
        }
    }
}

