public class Bank
{
    private List<BankAccount> _accounts = new List<BankAccount>();

    public void AddAccount(BankAccount account)
    {
        _accounts.Add(account);
    }

    public void DisplayAccounts()
    {
        foreach (BankAccount account in _accounts)
        {
            account.GetAccountInfo();
        }
    }

    public void DepositToAccount(int accountIndex, float money)
    {
        
    }

    public float WithdrawFromAccount(int accountIndex, float money)
    {
        return 0f;
    }
}