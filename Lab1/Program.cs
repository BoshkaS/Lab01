using System;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Task_1();
            Task_2();
            Task_3();
        }
        static void Task_1()
        {
            Console.WriteLine($"Введіть дійсне значення від 0 до 1:");
            Console.Write($"Перше значення x: ");
            double n = double.Parse(Console.ReadLine());

            if (n <= 0 || n >= 1)
            {
                Console.WriteLine("Incorrect values.");
                return;
            }
            string result = "0,";
            double preresult = n;
            int first_part = 0;
            char[] hexValues = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < 6; i++)
            {
                preresult *= 16;
                first_part = (int)preresult;
                preresult -= first_part;
                result += hexValues[first_part];
            }
            Console.WriteLine($"Відповідь до першого завадання: {result}");
        }
        static void Task_2()
        {
            Console.WriteLine($"Введіть три дійсних значення:");
            Console.Write($"Перше значення x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write($"Перше значення y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write($"Перше значення z: ");
            double z = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Incorrect values.");
                return;
            }

            double a = Math.Sqrt(4 * x * x + y * y) + z * z * z / (6);

            double b = 1 / Math.Sqrt(4 * x * x + y * y) + 5;

            double c = z * z * z / (6);

            double result = Math.Min(Math.Pow(Math.Max(a, b), 2), c * c);

            Console.WriteLine($"Відповідь до другого завадання: {result}");
        }
        static void Task_3()
        {
            Console.WriteLine($"Введіть значення матриці 7на6:");
            double[,] numbers = new double[7, 6];
            double[] preresult = new double[6];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < numbers.GetLength(1); ++j)
                {
                    Console.Write($"Значення [{i}][{j}]: ");
                    numbers[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < numbers.GetLength(0); ++j)
                {
                    if (numbers[j, i] > 0)
                    {
                        sum++;
                    }
                }
                preresult[i] = sum;
            }
            Console.Write($" Вектор c:");
            foreach (int i in preresult)
            {
                Console.Write($" {i} ");
            }

            Console.WriteLine($"Відповідь до третього завадання: {Array.IndexOf(preresult, preresult.Max())}");
        }
    }
}

