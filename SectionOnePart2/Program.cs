using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionOnePart2
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Main Menu");
            Console.WriteLine("\nSelect an operator:");
            Console.WriteLine("1) + for Add");
            Console.WriteLine("2) - for Subtract");
            Console.WriteLine("3) * for Multiply");
            Console.WriteLine("4) / for Divide");
            Console.Write("\r\nYour selection:");
            
            Program p = new Program();
            p.Calculate(200, 100, "1");

        }

        public void Calculate(int operand1, int operand2, string ops)
        {
            double add, sub, mul, div;

            Console.WriteLine("Enter operand 1:");
            operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operand 2:");
            operand2 = Convert.ToInt32(Console.ReadLine());

            ops = Console.ReadLine();

            switch(ops)
            {
                case "1":
                    add = operand1 + operand2;
                    Console.WriteLine("Addition:", add);
                    break;
                case "2":
                    sub = operand1 - operand2;
                    Console.WriteLine("Subtraction:", sub);
                    break;
                case "3":
                    mul = operand1 * operand2;
                    Console.WriteLine("Multiplication:", mul);
                    break;
                case "4":
                    div = operand1 + operand2;
                    Console.WriteLine("Division:", div);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid operation");
                    break;
            }
            Console.ReadLine();
            
        }
        
    }
    
}
