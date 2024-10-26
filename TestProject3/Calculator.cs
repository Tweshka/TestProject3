public abstract class Account
{
    public double Balance { get; set; }
    public double Interest { get; protected set; }

    public abstract void CalculateInterest();
}

public class OrdinaryAccount : Account
{
    public override void CalculateInterest()
    {
        Interest = Balance * 0.4;
        if (Balance < 1000)
            Interest -= Balance * 0.2;
        else if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}

public class SalaryAccount : Account
{
    public override void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}

// ������ �������������
public class AccountCalculator
{
    public void Calculate(Account account)
    {
        account.CalculateInterest();
    }
}