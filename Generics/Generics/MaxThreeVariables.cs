using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MaxThreeVariables
    {
        public  static void CheckMaxNumber<T>(T firstValue, T secondValue , T thirdValue)where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue)<0)
            {
                Console.WriteLine("First Number is greater");
            }
            if (secondValue.CompareTo(thirdValue) > 0 )
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
