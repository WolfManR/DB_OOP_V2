using Bank.Core;
using static System.Console;

namespace Bank.UIConsole
{
    public class Printer
    {
        public void Print(BankAccount bankAccount)
        {
            WriteLine($"Bank account {bankAccount.Id} of type {bankAccount.Type}");
            WriteLine($"Balance: {bankAccount.Balance}");
        }
    }
}