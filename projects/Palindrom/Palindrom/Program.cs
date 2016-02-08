using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Два цикла: с проверкой в конце и в начале.
// Внешний цикл - образец многократно решаемой задачи.
// Завершение цикла определяется в диалоге с пользователем.
namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        { 
   string answer, text;
   do
   {
      Console.WriteLine("Введите слово");
      text = Console.ReadLine();
      int i =0, j = text.Length-1;
      while ((i<j) && (text[i] == text[j]))
         {i++; j--;}
      if (text[i] == text[j])
         Console.WriteLine(text +" - это палиндром!");
      else
         Console.WriteLine(text +" - это не палиндром!");
      Console.WriteLine("Продолжим? (y/n)");
      answer = Console.ReadLine();
   }
   while(answer =="y");
}
    }
 }

    
