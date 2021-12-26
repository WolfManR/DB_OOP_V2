using Bank.Core;
using Bank.UIConsole;


Printer printer = new();

BankAccount bankAccount = new(5m);
BankAccount bankAccount2 = new(BankAccountType.Deposit);
BankAccount bankAccount3 = new(10.3m, BankAccountType.Credit);

printer.Print(bankAccount);
printer.Print(bankAccount2);
printer.Print(bankAccount3);

bankAccount.Deposit(19.2m);
bankAccount.Deposit(144.67m);
bankAccount.TryWithdraw(120.2m);

printer.Print(bankAccount);