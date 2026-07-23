using System;

class Program
{
    static void Main(string[] args)
    {
        Bank newBank = new Bank();
        Console.WriteLine("Menu");
        Console.WriteLine("");
        string response = "";
        BankAccount newBankAccount = new BankAccount("Renz", 1000);
        while (response != "4")
        {
            Console.WriteLine("1. View Accounts");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Quit");
            Console.WriteLine("");
            Console.Write("Choice: ");
            response = Console.ReadLine();
            
            if (response == "1") // view accounts
            {
                Console.WriteLine(newBankAccount.GetAccountInfo());
            }
            
            else if (response == "2") // deposit
            {
                Console.Write("Enter amount to deposit: ");
                float money = float.Parse(Console.ReadLine());
                newBankAccount.Deposit(money);
                Console.WriteLine($"${money} was deposited to the account.");
            }

            else if (response == "3") // withdraw
            {
                Console.Write("Enter amount to withdraw: ");
                float money = float.Parse(Console.ReadLine());
                newBankAccount.Withdraw(money);
                Console.WriteLine($"${money} was withdrawn to the account.");
            }
            
            else
            {
                break;
            }
        }


    }
}