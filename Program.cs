namespace oppgaveC__klasser_metoder_interfaces;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(3, 4));

        Console.WriteLine(calculator.Subtract(9, 5));

        Console.WriteLine(calculator.Multiply(3, 3)); 

        Console.WriteLine(calculator.Divisor(8, 3));
    }
}
