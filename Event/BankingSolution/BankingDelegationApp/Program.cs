using Banking.AccountMgmt;
using Finacle.Banking.AccountMgmt.Receivers;
using BankingDelegationApp;

Account acct = new Account(70000);
AccountListener listener = new AccountListener();
//listener.AactivateAccount(null, null);  //direct call

EventArgs eventArgs = new EventArgs();

//Register Address of the function while creating delegate
BankingHandler handler = new BankingHandler(listener.AactivateAccount);

//unicast /singlecast delegate
//handler(acct, eventArgs);       //Indirect call

//registration, attaching, Add handler,plug
handler += listener.DeactivateAccount;

handler += listener.SendEmail;

handler += listener.SendSMS;

//unRegistration,detaching,Remove handler,unplug
handler -= listener.SendSMS;

//multicast delegate
handler(acct, eventArgs);

ArithmaticOperation arithmaticOperation = new ArithmaticOperation();

ArithmaticHandler handler1 = new ArithmaticHandler(arithmaticOperation.Addition);
handler1 += arithmaticOperation.Substraction;
handler1 += arithmaticOperation.Multiplication;
handler1 += arithmaticOperation.Division;
handler1(10 , 2);
