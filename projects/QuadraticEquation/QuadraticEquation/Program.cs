using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый коэффициент a:");
            float a = float.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Введите второй коэффициент b:");
            float b = float.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Введите третий коэффициент c:");
            float c = float.Parse(Console.ReadLine().Trim());
            //Вычисление дискриминанта
            float d = b * b - 4 * a * c;
            if (a == 0) // Ошибка 1
            {
                Console.WriteLine("Уравнение не является квадратным:{0}*x+{1}=0", b, c);
                if (b == 0) // Ошибка 2
                {
                    Console.WriteLine("Чувак - это уже не уравнение!");
                }
                if (d < 0)
                {
                    Console.WriteLine("Дискриминант d<0. Действительных корней уравнения нет!");
                }
                else
                {
                    float x1, x2;
                    if (d == 0)
                    {
                        x1 = x2 = -(b / 2 * a);
                        Console.WriteLine("Дискриминант = 0, x = {0}", x1);

                    }
                    else
                    {
                        //Извлекаем корень из Дискриминанта
                        float sqrtD = (float)System.Math.Sqrt(d);
                        x1 = (-b + sqrtD) / (2 * a);
                        x2 = (-b - sqrtD) / (2 * a);

                    }
                    //Вывод
                    Console.WriteLine("Дискриминант = {0}, x1 = {1}, x2 ={2}", d, x1, x2);

                }

                Console.ReadLine();
            }
        }
    }
}