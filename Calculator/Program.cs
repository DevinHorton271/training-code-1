using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our Basic Calculator!");
            var stay = true;

            do
            {
            Console.WriteLine("Menu");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 to Exit");

            var choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    // var input1 = (double)Console.ReadLine(); //explicit casting with exception
                    // var input2 = Console.ReadLine() as double; //explicit casting with null

                    var input1 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                    double input2;
                    double.TryParse(Console.ReadLine(), out input2); //explicit parsing with exception

                    Add(input1, input2);
                    break;
                case "2":
                    var subinput1 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                    double subinput2;
                    double.TryParse(Console.ReadLine(), out subinput2); //explicit parsing with exception

                    Subtract(subinput1, subinput2);
                    break;
                case "3":
                    double.TryParse(Console.ReadLine(), out input1);
                    double.TryParse(Console.ReadLine(), out input2);

                    Multiply(input1, input2);
                    break;
                case "5":
                stay = false;
                break;
            }
        } while (stay);

        static void Add(double operand1, double operand2) 
        {
            var result = operand1 + operand2;
            Console.WriteLine($"Your answer is: {result}");
        }
        static void Subtract(double operand1, double operand2)
        {
            var result = operand1 - operand2;
            Console.WriteLine($"Your answer is: {result}");
        }
        static void Multiply(double operand1, double operand2)
        {
            var result = operand1 * operand2;
            Console.WriteLine($"Your answer is: {result}");
        }
    }
}
}
