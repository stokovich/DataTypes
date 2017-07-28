using System;

class ComparingFloats
{
    static void Main()
    {
        double num1;
        double num2;
        decimal eps = 0.000001m;
        decimal result;

        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());
        
        if (num1 > num2)
        {
            result = (decimal)num1 - (decimal)num2;
            if (result < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        else
        {
            result = (decimal)num2 - (decimal)num1;
            if (result < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
