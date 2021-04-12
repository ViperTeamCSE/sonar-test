using System;

public class BadMath : IDisposable
{

    public int factorial(int x) {
        if (x == 0)
            return 1;
        else 
            return x * factorial(x - 1);
    }

    public void Dispose()
    {
        
    }
}