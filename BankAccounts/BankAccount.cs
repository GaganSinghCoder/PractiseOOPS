namespace Classes;

public abstract class BankAccount
{

    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }
    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Balance = initialBalance;
    }

    public BankAccount(string name)
    {
        this.Owner = name;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
    public abstract void OpenAccount(DateTime dateTime);
    
}
