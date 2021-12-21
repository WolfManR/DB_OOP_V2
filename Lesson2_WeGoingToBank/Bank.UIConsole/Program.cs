using Bank.Core;
using Bank.UIConsole;


Printer printer = new();

BankAccount bankAccount = new(BankAccountType.Deposit);

bankAccount.Deposit(19.2m);
bankAccount.Deposit(144.67m);
bankAccount.TryWithdraw(120.2m);

printer.Print(bankAccount);