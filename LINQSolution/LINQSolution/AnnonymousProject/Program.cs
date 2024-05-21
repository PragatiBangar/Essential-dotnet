using AnnonymousProject;
using AccountProject;
using Transflower;

//Annonymous Type
Person person1= new ();
person1.Id = 1;
person1.FirstName = "pragati";
person1.LastName = "bangar";
Console.WriteLine(person1.FirstName +" "+ person1.LastName);

//Property Initializer syntax
Person person2= new Person
{
    Id = 2,
    FirstName="Reshma",
    LastName="Bhor"
};
Console.WriteLine(person2.FirstName + " " + person2.LastName);

//Annonymous Type
// a type with a class declaration

//Variant Data Type
var product = new { Id=1,Title="rose",description="beautiful flower",UnitPrice=50};

Console.WriteLine(product.Id+" "+product.Title);

//strong datatype

double num = 26.67;
num = 45.71;


int count = 23;
count = 45;


//var data type
var number1 = 50;  //at runtime type of variable is decided
number1 = 30;
number1 = 40;
//number1 = true;   //doesn't access another datatype

//dynamic data type
dynamic number2 = 34;
number2 = true;
number2 = 54.23;

number2 = new
{
    Id = 1,
    name = "pravin"
};

Account acct = new Account(10000);
SavingAccount savingAccount = new SavingAccount(30000);
savingAccount.Deposit(1000);
Console.WriteLine(savingAccount.Balance);
savingAccount.Withdraw(1000);
Console.WriteLine(savingAccount.Balance);
savingAccount.ShowMiniStatement();
savingAccount.PrintStatement();
savingAccount.ShowSMS();

//Annonymous Method
TransflowerOperations transflowerDelegates = delegate(string msg)
{
    Console.WriteLine(msg+" msg is successfully registered");
};

transflowerDelegates("pragati");

TransflowerOperations operations = (string msg) => { Console.WriteLine(msg + " msg sregistered"); };
operations("raghav");


