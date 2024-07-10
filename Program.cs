using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordLimetedAmountOfInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "12345";
            string userInput;
            int tryCount = 3;
            
            while (tryCount > 0)
            {
                Console.WriteLine("Введите пароль");
                userInput = Console.ReadLine();

                if (password.Equals(userInput))
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль неверен =(! У вас осталось " + (tryCount - 1) + " попыток.");
                    tryCount--;

                    if (tryCount == 0)
                    {
                        Console.WriteLine("Ваше количество попыток кончилось, извините и досвидания!");
                    }
                }
            }
        }
    }
}
