using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = Input("day=");
            string d = GetDay(day);
        }
        static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        static string GetDay(int day)
        {
           switch(day)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пяница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                default: return "Out";

            }
             
        }
    }
}
