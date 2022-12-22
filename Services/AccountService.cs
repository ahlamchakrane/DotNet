namespace ConsoleApp.Services;

 //Créer l'interface AccountService avec les opérations : AddNewAccount, GetAllAccounts, GetAccountById, GetDebitedAccounts, GetBalanceAVG()
public interface AccountService
{
    Account AddNewAccount(Account account);
    List<Account> GetAllAccounts();
    Account GetAccountById(int id);
    List<Account> GetDebitedAccounts();
    double GetBalanceAVG();
}