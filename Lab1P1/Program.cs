using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstAnswer, secondAnswer;
            char doAgain;
            bool repeat1 = true;
            while(repeat1 == true) {
                
                Console.WriteLine("Hello user! Please enter your first 3-digit number.");
                firstAnswer = Console.ReadLine();

                Console.WriteLine("Thank you! Please enter your second 3-digit number.");
                secondAnswer = Console.ReadLine();

                Converter(Convert.ToInt16(firstAnswer), Convert.ToInt16(secondAnswer));

                Console.WriteLine("Would you like to run this program again? (Y or N)");
                doAgain = Convert.ToChar(Console.ReadLine());

                if(doAgain == 'y' || doAgain == 'Y')
                {
                    repeat1 = true;
                }
                else
                {
                    repeat1 = false;
                }

            }

        }

        public static void Converter(int firstNumber, int secondNumber)
        {
            int x1, x2, x3, y1, y2, y3, z1, z2, z3;

            if (firstNumber <= 999 && secondNumber <= 999)
                {
                    x1 = firstNumber / 100;
                    y1 = (firstNumber % 100) / 10;
                    z1 = firstNumber % 10;

                    x2 = secondNumber / 100;
                    y2 = (secondNumber % 100) / 10;
                    z2 = secondNumber % 10;

                    x3 = x1 + x2;
                    y3 = y1 + y2;
                    z3 = z1 + z2;
                    if (x3 == y3 && y3 == z3)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }

                }
                else
                {
                    Console.WriteLine("I'm sorry I do not recognize this entry.");
                }
                
            }
        }
    }
