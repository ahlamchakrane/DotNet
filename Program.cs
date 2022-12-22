using ConsoleApp.Services;

Console.WriteLine("Ahlam CHAKRANE Account's managment");

Account account1 = new Account(1, "MAD", 13055.53);
Account account2 = new Account(2, "$", -120.10);
Account account3 = new Account(3, "MAD", 65056.98);

Console.WriteLine(account1.ToString());

AccountService service = new AccountServiceImpl();
service.AddNewAccount(account1);
service.AddNewAccount(account2);
service.AddNewAccount(account3);

Console.WriteLine("Account 1 : " + service.GetAccountById(1));
Console.WriteLine();
Console.WriteLine("All accounts : ");
List<Account> all = service.GetAllAccounts();
foreach (Account account in all)
{
    Console.WriteLine(account.ToString());
}

Console.WriteLine();
Console.WriteLine("Balances Average : " + service.GetBalanceAVG()+ "MAD");

Console.WriteLine();
Console.WriteLine("Debited accounts : ");
foreach (Account account in service.GetDebitedAccounts())
{
    Console.WriteLine(account.ToString());
}