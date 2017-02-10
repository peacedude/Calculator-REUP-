using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool power = true;
            bool parsed = false;
            string option;
            int intOption;
            CalculateMath CalcMath = new CalculateMath();
            Hjalpmetoder Hjalp = new Hjalpmetoder();
            while(power == true) {
                do
                {
                    Console.Clear();
                    Hjalp.GetMenu();
                    option = Console.ReadLine();
                    parsed = int.TryParse(option, out intOption);
                    if (string.IsNullOrEmpty(option))
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else if(!parsed)
                    {

                    }
                    else
                    {
                        intOption = int.Parse(option);
                    }

                } while (string.IsNullOrEmpty(option) && parsed == false);
                power = Hjalp.TurnOff(intOption);

                Hjalp.SetOption(intOption);

            }
            
        }


    }
}
