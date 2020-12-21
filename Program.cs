using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Reflection;



namespace DZ
{



    class Program
    {

        static void Main(string[] args)
        {
        
            Console.WriteLine("введите n:");
            int n = int.Parse(Console.ReadLine());
            Log("n = "+ n);
            int m7 = 0, //  самое большое число, кратное 7, но не кратное 3
                m3 = 0,// самое большое число, кратное 3, но не кратное 7
                m21 = 0, // самое большое число, кратное 21
                max = 0, //самое большое число среди всех элементов последовательности, отличное от М21
                mpr;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    
                    Console.WriteLine($"введите x:");
                    int x = int.Parse(Console.ReadLine());// ввод данных
                    Log("x = " + x + "\n");

                    if (x % 7 == 0 && x % 3 != 0 && x > m7)// самое большое число, кратное 7, но не кратное 3
                        m7 = x;
                    Log("m7 = " + m7 + "\n");
                    if (x % 3 == 0 && x % 7 != 0 && x > m3)// самое большое число, кратное 3, но не кратное 7
                        m3 = x;
                    Log("m3 = " + m3 + "\n");
                    if (x % 21 == 0 && x > m21)// число кратное 26
                    {
                        if (m21 > max)
                            max = m21;
                        m21 = x;
                        Log("max = " + max + "\n");
                        Log("m21 = " + m21 + "\n");
                    }
                    else if (x > max) max = x;
                    Console.WriteLine($"введите res:");
                    int res = int.Parse(Console.ReadLine());
                    if (m21 * max > m7 * m3)
                    {
                        Console.WriteLine($"Вычисленное контрольное значение:{m21 * max}");
                        mpr = m21 * max;
                        Log("mpr = " + mpr + "\n");
                    }
                    else
                    {
                        Console.WriteLine($"Вычисленное контрольное значение:{m7 * m3}");
                        mpr = m7 * m3;
                        Log("mpr = " + mpr + "\n");
                    }
                    if (res == mpr)
                        Console.WriteLine("Контроль пройден");
                    else
                        Console.WriteLine("Контролько не пройден");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");

            }
        }
        public static void Log(string message)
        {
            try
            {
                File.AppendAllText("E:\\log.txt", message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!");
            }
        }

    }
}

