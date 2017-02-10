using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Hjalpmetoder
    {
        public void GetMenu()
        {
                Console.ResetColor();
                Console.WriteLine("Welcome to the Calculator, please choose an option.");
            Console.WriteLine("1. Add\n2. Sub\n3. Divide\n4. Multiply\n5. Quit");
        }

        public void SetOption(int option)
        {
            CalculateMath CalcMath = new CalculateMath();
            switch (option)
            {
                case 1:
                    CalcMath.Add();
                    GoBackToMenu();
                    break;
                case 2:
                    CalcMath.Sub();
                    GoBackToMenu();
                    break;
                case 3:
                    CalcMath.Div();
                    GoBackToMenu();
                    break;
                case 4:
                    CalcMath.Mul();
                    GoBackToMenu();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                    break;
            }

        }
        public bool TurnOff(int option)
        {
            if (option == 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void GoBackToMenu()
        {
            Console.Write("\nPress any key to go back to menu..");
            Console.ReadKey();
        }
    }
}
