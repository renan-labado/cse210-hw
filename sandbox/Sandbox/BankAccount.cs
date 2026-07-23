public class BankAccount
{
    private string _ownerName;
    private float _balance;

    public BankAccount(string name, float balance)
    {
        _ownerName = name;
        _balance = balance;
    }

    public void Deposit(float money)
    {
        _balance = _balance + money;
    }

    public void Withdraw(float money)
    {
        _balance -= money;
    }

    private float GetBalance()
    {
        return _balance;
    }

    public string GetAccountInfo()
    {
        return $"Owner: {_ownerName} Balance: {GetBalance()}";
    }


}