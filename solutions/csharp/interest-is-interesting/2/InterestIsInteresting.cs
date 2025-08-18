using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance) => 
        (balance < 0, balance < 1000, balance < 5000, balance >= 5000) switch
       { (true, _ , _ , _) => 3.213f,
        (false, true, _, _) => 0.5f,
        (_, false, true, _) => 1.621f,
        (_,_,_,true) => 2.475f,
        };

    public static decimal Interest(decimal balance) => balance * ((decimal)InterestRate(balance) /100);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);
  
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int y = 0;
        while (balance < targetBalance){
            y++;
            balance = AnnualBalanceUpdate(balance);
        }
    return y;
    }
}
