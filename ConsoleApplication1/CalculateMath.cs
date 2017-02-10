using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculateMath
    {
        public double num1, num2;
        /*public void Add()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }*/
        public void Sub()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());
            double sum = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + sum);
        }
        public void Div()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter second number: ");
                num2 = double.Parse(Console.ReadLine());
            } while (num2 == 0);
            
            double sum = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + sum);
        }
        public void Mul()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());
            double sum = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + sum);
        }
        public void Add()
        {
            Console.Clear();
            List<double> list = new List<double>();
            bool loop = true;
            Console.WriteLine("Type 0 to get sum");
            while (loop == true)
            {
                Console.Write("\nEnter a number: ");
                num1 = double.Parse(Console.ReadLine());
                if (num1 == 0)
                {
                    loop = false;
                }
                else
                {
                    list.Add(num1);
                }
                
                    
            }
            Console.Write("Sum: " + list.Sum(x => Convert.ToInt32(x)));

        }
    }
}
