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
        public void CheckMaxNumber(double first, double second, double third)
        {
            if (first.CompareTo(second) < 0 && first.CompareTo(third) < 0)
            {
                Console.WriteLine("First Number is greater");
            }
            if (second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is greater");
            }
            else
            {
                Console.WriteLine("Third Number is greater");
            }

        }
        public void CheckMaxNumber(string firstNum,string secondNum,string thirdNum)
        {
            if (firstNum.CompareTo(secondNum) < 0 && firstNum.CompareTo(thirdNum) < 0)
            {
                Console.WriteLine("String One is greater");
            }
            if (secondNum.CompareTo(thirdNum) > 0)
            {
                Console.WriteLine("String Two is greater");
            }
            else
            {
                Console.WriteLine("String Three is  greater");
            }

        }
    }
}
