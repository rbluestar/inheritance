// See https://aka.ms/new-console-template for more information
class Debitcard
{
    public void Withdraw()
    {
        Console.WriteLine("Card is inserted.");
    }
}
class SbiCard : Debitcard
{
    public void WithdrawOne()
    {
        Console.WriteLine("SBI card inserted...");
    }
    public void MoneyTransfer()
    {
        Console.WriteLine("SBI money transfering...");
    }
}

class IcicCard : SbiCard
{
    public void WithdrawTwo()
    {
        Console.WriteLine("Icic Debit card");
    }
    static void Main(string[] args)
    {
       IcicCard s = new IcicCard();
        s.Withdraw();
        s.WithdrawOne();
       
        s.WithdrawTwo();
        s.MoneyTransfer();
        Console.Read();
    }
}
