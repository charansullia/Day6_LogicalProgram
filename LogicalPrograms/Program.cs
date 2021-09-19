using System;

namespace LogicalPrograms
{
    class Program
    {
        public void Viewprogram()
        {
            Console.WriteLine("WELCOME TO LOGICAL PROBLEMS");
            Console.WriteLine("1. Fibonacci Series\n" +
                "2.Perfect number\n" +
                "3.Prime number\n" +
                "4.Reverse\n" +
                "5.day of week\n" +
                "6.Temperature Conversion\n" +
                "7.Monthly payment\n" +
                "8.Decimal to binary\n"+
                "9.StopWatch");
            Console.WriteLine("enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.series();
                    break;
                case 2:
                    PerfectNumber perfectnumber = new PerfectNumber();
                    perfectnumber.Perfect();
                    break;
                case 3:
                    PrimeNumber primenumber = new PrimeNumber();
                    primenumber.Prime();
                    break;
                case 4:
                 ReverseNumber reverse = new ReverseNumber();
                   reverse.Reverse();
                    break;
                case 5:
                    DayofWeek dw = new DayofWeek();
                    dw.Days();
                    break;
                case 6:
                    TemperaturConvrsn temp = new TemperaturConvrsn();
                    temp.Tempcrsn();
                    break;
               case 7:
                    MonthlyPaymnt paymnt = new MonthlyPaymnt();
                    paymnt.Payment();
                    break;
                case 8:
                    DecimaltoBinary decimtoBin = new DecimaltoBinary();
                    decimtoBin.DtoB();
                    break;
                case 9:
                    StopWatch Watch = new StopWatch();
                    Watch.Timer();
                    break;
                default:
                    Console.WriteLine("enter valid key");
                    break;
            }
            Console.WriteLine("\nDo you wants to see any other program.....if yes then preass Y or else  N");
            char yesno = Convert.ToChar(Console.ReadLine());
            if (yesno == 'Y' || yesno == 'y')
            {
                Console.WriteLine("........................................................................................");
                Viewprogram();
            }
        }
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Viewprogram();

        }
    }
}
