using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int i=0;
            Console.WriteLine("Введите пожалуйста число:");
            i = int.Parse(Console.ReadLine());

            do
            { i++;
                Console.WriteLine(i);
            }

            while ((i>=1) && (i< 23));
            
            Console.ReadLine();

        }
     }
}
