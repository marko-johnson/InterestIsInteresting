static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        
        if (balance >= 0m && balance < 1000m)
        {
            return 0.5f;
        }
        else if (balance >= 1000m && balance < 5000m)
        {
            return 1.621f;
        }
        else if (balance >= 5000m)
        {
            return 2.475f;
        }
        else
        {
            return 3.213f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        //decimal b = balance;
        //float f = InterestRate(balance);
        //decimal result = b * ((decimal)f);
        //return result;

        //decimal b = balance;
        //float f = InterestRate(balance);
        //float result = ((float)b) * f; 

        //return result;
       return balance * (decimal)InterestRate(balance) * 0.01m;
        
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        //decimal result = (targetBalance - balance) / Interest(balance);
        //return (int)result;
        return ((int)targetBalance - (int)balance) / (int)Interest(balance);

        //do
        //{
        //    ((int)targetBalance - (int)balance) / (int)Interest(balance);
        //}
        //while (balance < targetBalance) ;
    }
}
