
using Banking.Console.Models;
using Banking.Console.Services;

Account acc1 = new SavingAccount("ACC001", "Andi", 500000);
Account acc2 = new CurrentAccount("ACC002", "Budi", 300000);

Console.WriteLine("Sebelum:");
acc1.ShowInfo();
Console.WriteLine();
acc2.ShowInfo();
Console.WriteLine();

TransferService transfer = new TransferService(acc1, acc2);

transfer.Debit(100000);

Console.WriteLine("\nSesudah:");
acc1.ShowInfo();
Console.WriteLine();
acc2.ShowInfo();
Console.WriteLine();



