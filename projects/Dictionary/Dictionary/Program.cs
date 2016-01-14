using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dictionary
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
      static void Main()
        {
                Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Троу [Throw]", "Сроу [θrəʊ]" );
            dic.Add("Парсе [Parse]", "Парс [pɑːrs]");
            dic.Add("Матч [Math]", "Мэс [mæθ]" );
            dic.Add("Джет [Get]", "Гет [ɡet]" );
            dic.Add("Трэй [Try]", "Трай [traɪ]";
            dic.Add("Анчекид [Unchecked]", "Анчект [ʌnˈtʃekt]");
            dic.Add("Имплой [Employee]", "Имплойи [ɪmˈplɔɪiː]");
            
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                MessageBox.Show(string.Format("Правильное название {0} это {1}", kvp.Key, kvp.Value));
            } 

        }
    }
}
