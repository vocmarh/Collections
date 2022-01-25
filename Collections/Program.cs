using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку содержащую скобки (), [], {}:");
            string b = Console.ReadLine();
            Stack<char> brackets = new Stack<char>();
            char Bracket = '?';
            foreach (char i in b)
            {
                if (brackets.Count != 0)
                {
                    switch (brackets.Peek())
                    {
                        case '(':
                            Bracket = ')';
                            break;
                        case '{':
                            Bracket = '}';
                            break;
                        case '[':
                            Bracket = ']';
                            break;
                        default:
                            break;
                    }
                }
                if ("({[".Contains(i))
                {
                    brackets.Push(i);
                    continue;
                }
                if (")}]".Contains(i) && Bracket == i)
                {
                    brackets.Pop();
                    continue;
                }
                if (")}]".Contains(i) && Bracket != i)
                {
                    break;
                }
            }
            if (brackets.Count == 0)
            {
                Console.WriteLine("Правильное расположение скобок");
            }
            else
            {
                Console.WriteLine("Неправильное расположение скобок");
            }
            Console.ReadKey();
        }
    }
}