using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int acum = 0;
        while (max > 0){
            acum += max;
            max--;
        }
    return acum*acum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int acum=0;
         while(max > 0 ){
             acum += max*max;
             max--;
         }
    return acum;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}