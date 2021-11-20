using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Maxintegernumbers,2-Maxfloatnumber,3-Maxstrings,4-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the integer values:");
                        int firstNum = Convert.ToInt32(Console.ReadLine());
                        int secondNum = Convert.ToInt32(Console.ReadLine());
                        int thirdNum = Convert.ToInt32(Console.ReadLine());
                        MaxThreeVariables.CheckMaxNumber(firstNum,secondNum,thirdNum);
                        break;
                    case 2:
                        Console.WriteLine("Enter the float values:");
                        double firstNumb = Convert.ToDouble(Console.ReadLine());
                        double secondNumb = Convert.ToDouble(Console.ReadLine());
                        double thirdNumb = Convert.ToDouble(Console.ReadLine());
                        MaxThreeVariables.CheckMaxNumber(firstNumb, secondNumb, thirdNumb);
                        break;
                    case 3:
                        Console.WriteLine("Enter the string values:");
                        string firstNumbr = Convert.ToString(Console.ReadLine());
                        string secondNumbr = Convert.ToString(Console.ReadLine());
                        string thirdNumbr = Convert.ToString(Console.ReadLine());
                        MaxThreeVariables.CheckMaxNumber(firstNumbr, secondNumbr, thirdNumbr);
                        break;

                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
