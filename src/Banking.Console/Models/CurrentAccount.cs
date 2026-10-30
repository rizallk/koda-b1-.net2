using Banking.Console;

namespace Banking.Console.Models;

public class CurrentAccount(string accountNumber, string ownerName, int balance) : Account(accountNumber, ownerName, balance)
{

  public override void IncreaseBalance(int amount)
  {
    base.IncreaseBalance(amount);
  }

  public override void DecreaseBalance(int amount)
  {
    base.DecreaseBalance(amount);
  }
}