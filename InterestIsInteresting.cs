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

    public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) * 0.01m;

    public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;
    
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int iterationCount = 0;

        do
        {
            balance = balance + Interest(balance);
            iterationCount++;
        }
        while (balance < targetBalance);

        return iterationCount;
    }
}
