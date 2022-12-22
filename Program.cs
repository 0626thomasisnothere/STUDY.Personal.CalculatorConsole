namespace CalculatorProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                List<double> numInputs = new List<double> { };
                string numInput = "";
                double result = 0;
                int userDigit;
                string userInput;
                double cleanNum = 0;

                // Ask the user to choose an operator.

                Console.WriteLine("How many digits you want to enter?");

                userInput = Console.ReadLine();
                    
                while(!int.TryParse(userInput, out userDigit))
                {
                    Console.Write("Invalid input. Please try again:");
                    userInput = Console.ReadLine();
                }
                if (userDigit > 1)
                {
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\tp - To the power of (only for 2 digits)");
                    Console.WriteLine("\td - Divide");
                }
                else
                {
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\ts - Square root");
                    Console.WriteLine("\tp - Power of two");
                    Console.WriteLine("\tsin - Trigonometry Sin()");
                    Console.WriteLine("\tcos - Trigonometry Cos()");
                    Console.WriteLine("\ttan - Trigonometry Tan()");
                }
                Console.Write("Your option? ");


                string menu = Console.ReadLine();
                while (menu == null || userDigit > 2 && menu == "p")
                {
                    Console.Write("Invalid option picked. Please try again:");
                    menu = Console.ReadLine();
                }

                if (userDigit == 1)
                {
                    // Ask the user to type the first number.
                    Console.Write("Type a number, and then press Enter: ");
                    numInput = Console.ReadLine();


                    while (!double.TryParse(numInput, out cleanNum))
                    {
                        Console.Write("This is not valid input. Please enter an integer value: ");
                        numInput = Console.ReadLine();
                    }
                }
                else
                {
                    for (int i = 0; i < userDigit; i++)
                    {
                        Console.Write($"\nYour {i + 1} digit(s) is: ");
                        numInput = Console.ReadLine();
                        ;

                        while (!double.TryParse(numInput, out cleanNum))
                        {
                            Console.Write("This is not valid input. Please enter an integer value: ");
                            numInput = Console.ReadLine();
                        }
                        numInputs.Add(cleanNum);
                    }
                }

                try
                {
                    if (userDigit > 1)
                    {
                        result = Calculator.DoOperationWithTwoOrMany(numInputs, menu);
                    }
                    else
                    {
                        result = Calculator.DoOperationWithOne(cleanNum, menu);
                    }
                    
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("\nYour result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}