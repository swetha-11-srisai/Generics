﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MaxThreeVariables
    {
        public void CheckMaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) < 0 && firstNumber.CompareTo(thirdNumber)<0)
            {
                Console.WriteLine("First Number is greater");
            }
            if (secondNumber.CompareTo(thirdNumber) > 0 )
            {
                Console.WriteLine("Second Number is greater");
            }
            else
            {
                Console.WriteLine("Third Number is greater");
            }

        }
    }
}