public class Calculator : ICalculator
{
  public double Add(double a, double b)
  {
    return a + b;
  }

  public double Subtract(double a, double b)
  {
    return a - b;
  }

  public double Multiply(double a, double b)
  {
    return a * b;
  }

  public double Divisor(double a, double b)
  {
    return a / b;
  }
}