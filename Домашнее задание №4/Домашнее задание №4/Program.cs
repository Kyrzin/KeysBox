using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            double operand1, operand2,asd=2;
            Console.WriteLine("Введите первое значение!");
            operand1 = Convert.ToDouble(Console.ReadLine());
            string sign;
            Console.WriteLine("Что будем с ним делать?");
            sign =Console.ReadLine();
            Console.WriteLine("Введите второе значение!");
            operand2 = Convert.ToDouble(Console.ReadLine());
            switch (sign)
            {
                case "+": asd = operand1 + operand2;
                    break;
                case "-": asd = operand1 - operand2;
                    break;
                case "*": asd = operand1 * operand2;
                    break;
                case "/": asd=operand1 / operand2;
                    if (operand2==0)
                    {
                        Console.WriteLine("На ноль делить нельзя!!!Нажмите 'У' если хотите начать заново ");
                        string dsa = Console.ReadLine();
                        if (dsa == "y")
                        {
                            goto Start;
                        }
                        else { return; }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Операция {0} \nРезультат {1}",sign,asd);
            Console.ReadKey();
        }
    }
}
