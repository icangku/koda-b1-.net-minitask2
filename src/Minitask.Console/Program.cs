// See https://aka.ms/new-console-template for more information
using Minitask.Console.Interface;
using Minitask.Console.Models;
using Minitask.Console.Services;

Console.WriteLine("==========KOPERASI KODA ACADEMY===============");
Account savingAcc = new SavingAccount("S01", "Alvin Corwin", true, 5_000_000_000);
Account currAcc = new CurrentAccount("C01", "Alvin Corwin", true, 1_000);

List<Account> listAccounts =
[
  savingAcc, currAcc
];

foreach(Account acc in listAccounts){
  Console.WriteLine(acc.GetInformation());
}

ITransferService transferService = new TransferService();
try
{
  transferService.Transfer(savingAcc, currAcc, 5_000_000);
  Console.WriteLine("Transfer Done!");

  foreach(Account acc in listAccounts){
    Console.WriteLine(acc.GetInformation());
  }
}
catch(Exception ex)
{
  Console.WriteLine(ex.Message);
}