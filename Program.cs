using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool ranOnce = false;
            double result = 0;

            while(!ranOnce)
            {
                double num1 = getInput();
                double num2 = getInput();
                char oper = getOperator();  
                operation(num1, num2, oper);
                ranOnce = true;
            }

            if(ranOnce)
            {
            again:
                Console.Write("Continue ? (y/n): ");
                String con = Console.ReadLine();

                if(con == "y")
                {
                    double newNum = getInput();
                    char oper = getOperator();
                    operation(result, newNum, oper);
                } else if(con == "n")
                {
                    Environment.Exit(0);
                }
                goto again;
                
            }
         


            double getInput()
            {
                writeNumber:
                Console.Write("Enter number: ");
                string num = Console.ReadLine();
                double numValue = 0;
                
                if(double.TryParse(num, out numValue)){
                    return double.Parse(num);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                    goto  writeNumber;
                }
            }

            char getOperator()
            {
                writeOperator:
                Console.Write("Enter operator: ");
                /*string opValue = Console.ReadLine();*/

                char opValue = Console.ReadKey().KeyChar;

                if(opValue == '+' || opValue == '-' || opValue == '*' || opValue == '*')
                {
                    return opValue;

                }
                else
                {
                    Console.WriteLine("\nInvalid Operator. Try Again.");
                    goto writeOperator;
                }

            }

            void operation(double n1, double n2, char opValue)
            {

                switch(opValue)
                {
                    case '+':
                        result = n1 + n2;
                        break;

                    case '-':
                        result = n1 - n2;
                        break;


                    case '*':
                        result = n1 * n2;
                        break;

                    case '/':
                        result = n1 / n2;
                        break;

                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine(n1 + " " + opValue + " " + n2 + " = " + result);
            }
        }
    }
}
