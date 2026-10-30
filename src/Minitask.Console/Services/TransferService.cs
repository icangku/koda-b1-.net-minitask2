using Minitask.Console.Interface;
using Minitask.Console.Models;

namespace Minitask.Console.Services;


public class TransferService: ITransferService
{
  public void Transfer(Account source, Account destination, decimal amount)
  {
    if(source.Id == destination.Id)
    {
      throw new InvalidOperationException("Source and Destination cannot be same");
    }

    if(!source.IsActive || !destination.IsActive)
    {
      throw new ArgumentException("Sorry, both account should active");
    }

    source.DeductBalance(amount);
    destination.AddBalance(amount);
  }
}