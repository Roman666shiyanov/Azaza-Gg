using System;

namespace QuestionMax26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод n
            Console.WriteLine("Введите N");
            var n = int.Parse(Console.ReadLine());

            int max13, maxEven, beforeMax, max;
            max13 = maxEven = beforeMax = max = default;

            //ввод чисел
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ое число");
                var current = int.Parse(Console.ReadLine());

                if (current % 13 == 0 && current > max13)
                {
                    max13 = current;
                }
                if (current % 2 == 0 && current > maxEven)
                {
                    maxEven = current;
                }

                if (current > max)
                {
                    beforeMax = max;
                    max = current;
                }
                else if (current > beforeMax)
                {
                    beforeMax = current;
                }
            }

            //ввод контрольного значения
            Console.WriteLine("Введите контрольное значение:");
            var ctrl = int.Parse(Console.ReadLine());

            //Проверка контрольного значения
            if (max13 == 0)
            {
                Console.WriteLine(false);
                Console.WriteLine("Контроль не пройден!");
            }
            else
            {
                var res = 0;
                if (max13 % 2 == 0)

                {
                    if (!max13.Equals(max))
                    {
                        res = max13 * max;
                    }
                    else
                    {
                        res = max13 * beforeMax;
                    }
                }
                else
                {
                    res = max13 * maxEven;
                }
                Console.WriteLine("Контроль пройден");

                Console.WriteLine(res);
                Console.WriteLine(res.Equals(ctrl));

            }
        }
    }
}
