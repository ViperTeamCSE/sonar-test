using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var badmath = new BadMath();
            var x = 5;
            var y = 10;
            var xfac = badmath.factorial(x);
        }
    }
}
