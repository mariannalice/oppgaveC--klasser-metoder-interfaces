public interface ICalculator
{
 /// <summary>
 /// add method that adds two numbers together
 /// </summary>
 /// <param name="a">value of a</param>
 /// <param name="b">value of b</param>
 /// <returns>the sum of a + b</returns>
  double Add(double a, double b);

/// <summary>
/// subtract method that subtracts two numbers a and b
/// </summary>
/// <param name="a">value of a</param>
/// <param name="b">value of b</param>
/// <returns>the sum of a - b</returns>
  double Subtract(double a, double b);

/// <summary>
/// Multiply method that multiplies the number a & b
/// </summary>
/// <param name="a">value of a</param>
/// <param name="b">value of b</param>
/// <returns>the sum of a * b</returns>
  double Multiply(double a, double b);

/// <summary>
/// A method that devides the numbers a & b
/// </summary>
/// <param name="a">volume of a</param>
/// <param name="b">volume of b</param>
/// <returns>the sum of a / b</returns>
  double Divisor(double a, double b);
}