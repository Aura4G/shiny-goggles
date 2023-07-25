int factorial(int x)
{
    int factX = x;
    if (factX > 0)
    {
        for (int i = x; i >= 2; i--)
        {
            factX = factX * (i - 1);
        }
    }
    else
    {
        for (int i = x; i <= -2; i++)
        {
            factX = factX * (i + 1);
        }
    }
    
    return factX;
}