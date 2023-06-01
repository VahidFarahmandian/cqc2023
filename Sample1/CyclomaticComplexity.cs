class CyclomaticComplexity
{
    public int Calculate(int x, int y)
    {
        if (x < 0 && y < 0)
            if (x < y)
                return y;
            else if (x > y)
                return x + y;
            else
                return x;
        else
        if (x * y > 100)
            if (x < y)
                return x;
        return y;
    }
    //public int Calculate(int x, int y)
    //{
    //    if (x < 0 && y < 0)
    //        return CalculateNegative(x, y);
    //    else
    //        return CalculatePositive(x, y);
    //}

    //private int CalculateNegative(int x, int y)
    //{
    //    if (x < y)
    //        return y;
    //    else if (x > y)
    //        return x + y;
    //    else
    //        return x;
    //}
    //private int CalculatePositive(int x, int y)
    //{
    //    if (x * y > 100)
    //    {
    //        if (x < y)
    //            return x;
    //    }
    //    return y;
    //}
}