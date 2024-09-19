using System.Xml.XPath;

namespace oppgaveC__klasser_metoder_interfaces;

class Program
{
    static void Main(string[] args)
    {   
        // Creating an instance of Calculator
        Calculator myCalculator = new Calculator();

        // Using methods on the Calculator
        Console.WriteLine(myCalculator.Add(3, 4));

        Console.WriteLine(myCalculator.Subtract(9, 5));

        Console.WriteLine(myCalculator.Multiply(3, 3)); 

        Console.WriteLine(myCalculator.Divisor(8, 3));


        // Starting interactive Calculator
        Console.WriteLine("\n------------ Calculator --------------");

        while (true)
        {   
            // Getting desired operation from the user
            Console.WriteLine("\nWhat operation do you want?\n" + "+ , - , * , /");

            // Getting input from console, and avoiding null value
            string? oper = Console.ReadLine() ?? "";

            // Checking if operation is valid
            if("+-*/".Contains(oper))                                                
            {
                Console.WriteLine("\nYou selected: " + oper);

            } 
            else 
            {   
                Console.WriteLine("No valid operation input");
                // resetting loop to try again
                continue;
            }
            
            // Getting numbers for the Calculator
            Console.WriteLine("enter a number");
            double numA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter another number");
            double numB = Convert.ToDouble(Console.ReadLine());


            double result = 0;

            // Performing operation based on input
            switch(oper)
            {
                case "+":
                    result = myCalculator.Add(numA, numB);
                    break;

                case "-":
                    result = myCalculator.Subtract(numA, numB);
                    break;

                case "*":
                    result = myCalculator.Multiply(numA, numB);
                    break;

                case "/":
                    result = myCalculator.Divisor(numA, numB);
                    break;
                
            }

            // Providing result to user
            Console.WriteLine("The result of " + numA + oper + numB + " is: " + result);

            Console.WriteLine("\nDo you want to continue? " + "YES/NO");

            string? contAnswer = Console.ReadLine() ?? "";
            if(contAnswer.ToUpper() == "YES")
            {
                continue;
            }
            else
            {
                break;
            }
            
        }


    }


}
