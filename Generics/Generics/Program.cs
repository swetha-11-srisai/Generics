using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxThreeVariables max = new MaxThreeVariables();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Maxintegernumbers,2-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the integer values:");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        int thirdNumber = Convert.ToInt32(Console.ReadLine());
                        max.CheckMaxNumber(firstNumber,secondNumber,thirdNumber);
                        Console.WriteLine("The Maximum Number is :");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
