// See https://aka.ms/new-console-template for more information
using Banking.AccountMgmt;
using BankingApp;
using BankingApp.Receivers;
Console.WriteLine("Banking Solution");

Account account = new Account(60000);
/*Console.WriteLine(amount.Balance);*/

AccountListener listener = new AccountListener();



HDFCBank hDFCBank = new HDFCBank();
hDFCBank.PerformBankingOperation(account, listener);


Console.ReadLine();



/*account.Deposit(55000);
Console.WriteLine(account.Balance);*/