using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfRange
{
    class Program
    {
        static void Main(string[] args)
        {

            int percent = 0;
            Console.WriteLine("Введите количество процентов:");
            percent = int.Parse(Console.ReadLine());
                  try
            {
                if ((percent < 0) || (percent > 100))

                    throw new ArgumentOutOfRangeException();
                Console.WriteLine(percent);

                  }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Exception: Выход за границу диапазона");
                

            }
            Console.ReadLine();

        }
    }
}