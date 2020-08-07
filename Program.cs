using System;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; //input one
            int number2; //input two

            Console.WriteLine("Enter a value for the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);


            result = number1 * number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            double results2 = (double)number1 / (double)number2;  //divide 
            double results3 = number1 % number2;  //reminder (left over after division)
            Console.WriteLine("The answer is:");
            Console.WriteLine(results2);  //speficy to print the results to screen as a double.
            Console.WriteLine(results3);


            string name = "Krystal";
            var date = DateTime.Now;
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now", name, date.DayOfWeek, date);

            Console.WriteLine($"Hello,{name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);


            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                    num1, num2, num3, result);



        }
    }
}

