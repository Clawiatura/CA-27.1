class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine("Пополнение счета: " + amount);
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Снятие наличных: " + amount);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Текущий баланс: " + balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);

        account.CheckBalance();
        account.Deposit(500);
        account.CheckBalance();
        account.Withdraw(200);
        account.CheckBalance();
        account.Withdraw(1500);
    }
}