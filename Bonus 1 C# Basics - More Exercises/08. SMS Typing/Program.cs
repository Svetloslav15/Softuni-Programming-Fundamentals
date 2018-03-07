using System;

namespace _08._SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 1; i <= number; i++)
            {
                int code = int.Parse(Console.ReadLine());
                switch (code)
                {
                    case 2:message += 'a';break;
                    case 22:message += 'b';break;
                    case 222:message += 'c';break;
                    case 3: message += 'd'; break;
                    case 33: message += 'e'; break;
                    case 333: message += 'f'; break;
                    case 4: message += 'g'; break;
                    case 44: message += 'h'; break;
                    case 444: message += 'i'; break;
                    case 5: message += 'j'; break;
                    case 55: message += 'k'; break;
                    case 555: message += 'l'; break;
                    case 6: message += 'm'; break;
                    case 66: message += 'n'; break;
                    case 666: message += 'o'; break;
                    case 7: message += 'p'; break;
                    case 77: message += 'q'; break;
                    case 777: message += 'r'; break;
                    case 7777: message += 's'; break;
                    case 8: message += 't'; break;
                    case 88: message += 'u'; break;
                    case 888: message += 'v'; break;
                    case 9: message += 'w'; break;
                    case 99: message += 'x'; break;
                    case 999: message += 'y'; break;
                    case 9999: message += 'z'; break;
                    case 0: message += ' '; break;




                    default:
                        break;
                }
            }
            Console.WriteLine(message);
        }
    }
}
