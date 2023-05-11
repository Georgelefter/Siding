using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if( span==0 )
            return 1;

        int maxProduct = 0;
        if (span ==-1)
        {
            throw new ArgumentException();
        }
        if (digits == "")
        {
            throw new ArgumentException();
        }
        if (span > digits.Length)
        {
            throw new ArgumentException();
        }
        for (int m= 0;m<=digits.Length -span;m++)
        {
            if(digits[m]<48|| digits[m]>57)
            {
                throw new ArgumentException();
            }
        }
        for (int i = 0; i <= digits.Length - span; i++)
    {
        int product = 1;

        for (int j = i; j < i + span; j++)
        {
            product *= int.Parse(digits[j].ToString());
        }

        if (product > maxProduct)
        {
            maxProduct = product;
        }
    }
        return maxProduct;
    }
}
