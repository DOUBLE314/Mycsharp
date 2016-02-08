﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fimally_01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(@"C:\test.txt");
                sw.WriteLine("Hello");
            }

            catch (System.IO.FileNotFoundException ex)
            {
                // Put the more specific exception first.
                System.Console.WriteLine(ex.ToString());
            }

            catch (System.IO.IOException ex)
            {
                // Put the less specific exception last.
                System.Console.WriteLine(ex.ToString());
            }
            finally
            {
                sw.Close();
            }

            System.Console.WriteLine("Done"); 

        }
    }
}
