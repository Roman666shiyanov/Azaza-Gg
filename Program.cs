using System;
using System.IO;
namespace log
{
    class Program
    {
        static void Main(string[] args)
        {
            //get n
            
            Console.WriteLine("Введите N");
            var n = int.Parse(Console.ReadLine());
            Log("Введите N : " + n.ToString() + '\n');
            int max13, maxEven, beforeMax, max;
            max13 = maxEven = beforeMax = max = default;

            //get values
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ое число");
                var current = int.Parse(Console.ReadLine());
                Log("Введите N : " + current.ToString() + '\n');
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

            //get control value
            Console.WriteLine("Введите контрольное значение");
            var ctrl = int.Parse(Console.ReadLine());
            Log("Введите контрольное значение : " + ctrl.ToString() + '\n');

            //check control value
            if (max13 == 0)
            {
                Console.WriteLine(false);
                Log("" + false + '\n');
                Console.WriteLine("Контроль не пройден");


            }
            else
            {
                var res = 0;
                if (max13 % 2 == 0)
                {
                    if (!max13.Equals(max))
                    {
                        res = max13 * max;
                        Log("Значение 1 :" + res + '\n');
                    }
                    else
                    {
                        res = max13 * beforeMax;
                        Log("Значение 2 :" + res + '\n');
                    }
                }
                else
                {
                    res = max13 * maxEven;
                    Log("Значение 3 :" + res + '\n');
                }


                Console.WriteLine(res);
                Console.WriteLine(res.Equals(ctrl));
                Console.WriteLine("Контроль пройден");
                Log("" + true + '\n');
                Log("" + "Контроль пройден" + '\n');

            }
            static int GetNumber(string title)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine(title);
                        var textValue = Console.ReadLine();
                        if (!int.TryParse(textValue, out int result))
                        {
                            throw new Exception($"Не удалось конвертировать {textValue} в число");
                        }

                        return result;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
            static void Log(string message)
            {
                File.AppendAllText("C:\\44log.txt", message + Environment.NewLine);
            }
        }
    }
}
