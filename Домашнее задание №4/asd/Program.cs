using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Введи любое число от 0 до 100");
            int asd = Convert.ToInt32(Console.ReadLine());
            if (asd >= 0 && asd <= 14)
            {
                Console.WriteLine("Число между 0 и 14");
            }
            else if (asd >= 15 && asd <= 35)     
            {
                Console.WriteLine("Число между 15 и 35");      
            }
            else if (asd >= 36 && asd <= 50)
            {
                Console.WriteLine("Число между 36 и 50");
            }
            else if (asd >= 50 && asd <= 100)
            {
                Console.WriteLine("Число между 50 и 100");
            }
            else
            {
                Console.WriteLine("Хз какое число,Сказали же от 0 до 100!!!");
            }
            Console.WriteLine("Жилаете продолжить??");
            string dsa = Console.ReadLine();
            if (dsa == "y")
            {
                goto Start;
            }
            else { return; }

        
        
        }
    }
}
