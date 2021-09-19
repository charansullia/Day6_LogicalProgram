using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder, i = 0;
            int reverse = 0;
            int duplinumber = number;
            while (i < duplinumber)
            {
                remainder = duplinumber % 10;
                reverse = (reverse * 10) + remainder;
                duplinumber /= 10;
            }
            if (reverse == number)
                Console.WriteLine("Original number and reverse number are same");
            else
                Console.WriteLine("original number and reverse number are not same.Enter another number");
        }
    }
}





