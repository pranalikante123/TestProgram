using System;
namespace Operation
{
    public class Program
    {
        public static void Main()
        {
            double a, b, w, x, y, z;
            Console.WriteLine("*****Arithmatic Program*****");
            Console.Write("enter the 1st number:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the 2nd number:");
            b = Convert.ToDouble(Console.ReadLine());
            w = a + b;
            x = a - b;
            y = a * b;
            z = a / b;

            Console.WriteLine("addition: " + w);
            Console.WriteLine("subtraction: " + x);
            Console.WriteLine("Multiplication: " + y);
            Console.WriteLine("Divison: " + z);

            Console.ReadLine();

        }
    }
}