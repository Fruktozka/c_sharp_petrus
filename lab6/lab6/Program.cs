/*
 * Написати програму, що виконує наступні функції (ВИКОНАТИ ВСІ 8 (ВІСІМ) ПУНКТІВ):
 *  1.	Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
 *  2.	Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
 *  3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
 *  4.	Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного знаку” теж в зворотному (АБВ,ГДЕ->ВБА,ЕДГ)
 *  5.	Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних типів
 *  6.	Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів перевантажити
 *  7.	Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
 *  8.	Виконати пункт 7 з використанням ключових слів ref i out
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static string temp = string.Empty;
        static int modulo = 0;

        //reverse number
        private static void Reverse(int input, int len)
        {
            int result = 0;
            
            for (int i = 0; i < len; i++)
            {
                result += (int)input%10 * (int)Math.Pow(10,(len-i-1));
                input /= 10;
            }

            Console.WriteLine("");
            Console.WriteLine(result);
        }

        //reverse number recursively
        private static void ReverseRec(int input)
        {
            if (Math.Abs(input) > 0)
            {
                modulo = (int)input % 10;
                Console.Write(modulo);
                ReverseRec((int)input/10);
            }
        }

        //reverse string
        private static void Reverse(string input)
        {
            for(int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }

        //reverse string recursively
        private static void ReverseRec(string input)
        {
            if (input.Length > 0)
                ReverseRec(input.Substring(1, input.Length - 1));
            else
                return;

            Console.Write(input[0]);
        }

        //reverse double
        private static void Reverse(double input, int len)
        {
            int wholePart = 0;
            int delimiterPosition;
            double inp = input;
            double fraction = 0;

            int i = 0;
            while (inp >= 1)
            {
                i++;
                wholePart += (int)inp % 10 * (int)Math.Pow(10, (len - i - 1));
                inp /= 10;
            }
            wholePart /= (int)Math.Pow(10,len - i - 1);

            delimiterPosition = i + 1;
            inp = Math.Round(input%1, len - delimiterPosition)*Math.Pow(10, len-delimiterPosition);

            i = 0;
            int lenFraction = len - delimiterPosition;
            while (inp >= 1)
            {
                i++;
                fraction += (int)inp%10 * (int)Math.Pow(10, lenFraction-i);
                inp /= 10;
            }
            fraction /= (int)Math.Pow(10, lenFraction);

            Console.WriteLine("");
            Console.WriteLine(wholePart + fraction);
        }

        //reverse double recursively
        private static void ReverseRec(double input, int step)
        {
            if ((int)input >= 1)
            {
                modulo = (int)input % 10;
                Console.Write(modulo);
                input /= 10;
                ReverseRec(input, step + 1);
            }
            else
            {
                input = input * Math.Pow(10, step);
                input = Math.Truncate((input - Math.Truncate(input))*Math.Pow(10,input.ToString().Length - step - 1));

                if (input > 0)
                {
                    Console.Write(",");
                    ReverseRec(input, 0);
                }
            }
        }

        //reverse string with delimiter
        private static void Reverse(string input, int symbolPosition)
        {
            for(int i = symbolPosition - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            
            Console.Write(input[symbolPosition]);

            for(int i = input.Length - 1; i > symbolPosition; i--)
            {
                Console.Write(input[i]);
            }
        }

        private static void ArrReverse(int[] arr)
        {
            int tmp;
            int len = arr.Length;
            for (int i = 0; i < len/2; i++)
            {
                tmp = arr[i];
                arr[i] = arr[len - i - 1];
                arr[len - i - 1] = tmp;
            }
            Console.WriteLine("");
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            int answer = 0;
            string inputString = "";

            while (answer != 9)
            {
                Console.WriteLine("");

                Console.WriteLine("Select mode:");
                Console.WriteLine("1 -> integer reverse");
                Console.WriteLine("2 -> string reverse");
                Console.WriteLine("3 -> double reverse");
                Console.WriteLine("4 -> string with magic symbol reverse");
                Console.WriteLine("5 -> array reverse");
                Console.WriteLine("11 -> integer reverse recursively");
                Console.WriteLine("12 -> string reverse recursively");
                Console.WriteLine("13 -> double reverse recursively");
                Console.WriteLine("9 -> exit");

                Console.WriteLine("");

                answer = Convert.ToInt32(Console.ReadLine());

                if (answer != 9)
                {
                    Console.Write("Input ");

                    switch (answer)
                    {
                        case 1:
                            Console.WriteLine("input integer ");
                            inputString = Console.ReadLine();
                            Reverse(Convert.ToInt32(inputString), inputString.Length);
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("input string ");
                            Reverse(Console.ReadLine());
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.WriteLine("input double ");
                            inputString = Console.ReadLine();
                            Reverse(Convert.ToDouble(inputString), inputString.Length);
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.WriteLine("input string with magic symbol ");
                            //magic symbol is ,
                            inputString = Console.ReadLine();
                            Reverse(inputString, inputString.IndexOf(','));
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.WriteLine("array (input numbers delimited by space) ");
                            inputString = Console.ReadLine();
                            string[] strArr = inputString.Split(' ');
                            int[] inpArr = new int[strArr.Length];
                            for (int i = 0; i < strArr.Length; i++)
                            {
                                inpArr[i] = Convert.ToInt32(strArr[i]);
                            }
                            ArrReverse(inpArr);
                            Console.WriteLine("");
                            break;
                        case 11:
                            Console.WriteLine("input integer ");
                            inputString = Console.ReadLine();
                            ReverseRec(Convert.ToInt32(inputString), inputString.Length);
                            Console.WriteLine("");
                            break;
                        case 12:
                            Console.WriteLine("input string ");
                            ReverseRec(Console.ReadLine());
                            Console.WriteLine("");
                            break;
                        case 13:
                            Console.WriteLine("input double ");
                            inputString = Console.ReadLine();
                            ReverseRec(Convert.ToDouble(inputString), 0);
                            Console.WriteLine("");
                            break;
                    }
                }
            }

        }
    }
}
