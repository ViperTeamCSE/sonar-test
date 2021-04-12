using System;

public class BadMath : IDisposable
{

    public int factorial(int x) {
        if (x == 0)
            return 1;
        else 
            return x * factorial(x - 1);
    }

    public int FibonacciSeries(int n)  
        {  
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);  
        }  

    public void Dispose()
    {
        
    }
}