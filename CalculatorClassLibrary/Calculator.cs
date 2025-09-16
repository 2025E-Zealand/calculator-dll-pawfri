namespace CalculatorClassLibrary;

/// <summary>
/// This Calculator only support integers.
/// Static Methods for Add, Subtract, Multiply and Divide.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Add two numbers
    /// </summary>
    /// <param name="x">First number</param>
    /// <param name="y">Second number</param>
    /// <returns>Returns the sum</returns>
    public static int Add(int x, int y)
    { 
        return x + y; 
    }

    /// <summary>
    /// Subtract two numbers
    /// </summary>
    /// <param name="x">First number</param>
    /// <param name="y">Second number</param>
    /// <returns>Returns the sum</returns>
    public static int Subtract(int x, int y) 
    { 
        return x - y; 
    }

    /// <summary>
    /// Multiply two numbers
    /// </summary>
    /// <param name="x">First number</param>
    /// <param name="y">Second number</param>
    /// <returns>Returns the sum</returns>
    public static int Multiply(int x, int y)
    {  
        return x * y;
    }

    /// <summary>
    /// Divide two numbers
    /// </summary>
    /// <param name="x">First number</param>
    /// <param name="y">Second number</param>
    /// <returns>Returns the sum</returns>
    public static int Divide(int x, int y)
    {  
        if (x == 0 || y == 0)
        {
            return 0;
        }
        return x / y; 
    }
}
