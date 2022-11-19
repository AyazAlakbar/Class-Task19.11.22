using System;
using System.Collections.Generic;
using System.Text;

namespace h.w19._11._22_Class
{
    internal class Calculator
    {
        public int Num1;
        public int Num2;
        public int Result;
       
        public Calculator()
        {

        }

        public Calculator(int num1, int num2, int result)
        {
            Num1 = num1;
            Num2 = num2;
            Result = result;
        }

        public int Calculate()
        {
            try
            {
                char read = Convert.ToChar(Console.ReadLine());

                if (read=='+')
                {
                    Console.WriteLine("enter first number:");
                    double num1=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Answer:{num1+num2}");

                }
                else if(read == '-')
                {
                    Console.WriteLine("enter first number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Answer:{num1 - num2}");

                }
                else if (read == '*')
                {
                    Console.WriteLine("enter first number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Answer:{num1 * num2}");

                }
                else if (read == '/')
                {
                    Console.WriteLine("enter first number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Answer:{num1 / num2}");

                }
                else
                    Console.WriteLine("wrong input");
            }
            catch { Console.WriteLine("wrong input"); }

            return Result;
            
            

        }
    
    
    
    
    
    }
}
