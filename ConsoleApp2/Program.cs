using System;
public class Program
{
    public static void Main()
    {
        int num1 = Int32.MaxValue;
        Console.WriteLine("Multiplication of {0}x{0} without Math function - {1}", num1, num1 * num1);
        Console.WriteLine("Multiplication of {0}x{0} by Math BigMul function - {1}", num1, Math.BigMul(num1, num1));
    }
}
