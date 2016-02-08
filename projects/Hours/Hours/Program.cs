using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 5;
            if (hour >= 0 && hour < 24)
                Console.WriteLine("Переменная hour > 0 и меньше 24");
            else
                hour = 0;
            Console.ReadLine();
        }
    }
}
