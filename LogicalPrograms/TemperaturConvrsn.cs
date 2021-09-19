using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class TemperaturConvrsn
    {
        const int celsiustofar = 1;
        const int fahtocelsius = 2;
        public void Tempcrsn()
        {
            Console.WriteLine("Enter\n" +
                "1.for celcius to farenheit\n" +
                "2.For farenheit to celcius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case celsiustofar:
                    Console.WriteLine("enter the temperature in celcius");
                    double celcius = Convert.ToDouble(Console.ReadLine());
                    double c_f = (celcius * 9 / 5) + 32;
                    Console.WriteLine("temperature in " + celcius + "C" + " is equal to " + c_f + "F" + "in fahrenheit");
                    break;
                case fahtocelsius:
                    Console.WriteLine("enter the temperature in fahrenheit");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double f_c = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("temperature in " + fahrenheit + "F" + " is equal to " + f_c + "C" + "in fahrenheit");
                    break;
            }
        }
    }


}

