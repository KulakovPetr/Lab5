using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string InputString = Console.ReadLine();
            //Задание 1
            Console.WriteLine("Задание 1");
            string[] StringArray = SplitText(InputString);
            Print(StringArray);
            Console.ReadKey();
            //Задание 2
            Console.WriteLine("Задание 2");
            string ReversString = Reverse(InputString);
            Console.WriteLine(ReversString);
            Console.ReadKey();
        }
        static string[] SplitText(string text)
        {
            return text.Split();
        }
        static void Print(string[] args)
        {
            foreach(var e in args)
            {
                Console.WriteLine(e);
            }
        }
        static string Reverse(string text)
        {
            string result = "";
            string[] StringArray = SplitText(text);
            for (int i = StringArray.Length - 1; i>= 0; i--)
            {
                result += StringArray[i] + " ";
            }
            return result.Substring(0, result.Length-1);
        }

    }
}
