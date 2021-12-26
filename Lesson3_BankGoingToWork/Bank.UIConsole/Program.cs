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

const decimal transferAmount = 40m;
string transferMessage = $"Transfer of sum {transferAmount} from {bankAccount.Id} to {bankAccount2.Id} was";
bool transferResult = bankAccount.TryDepositTo(bankAccount2, transferAmount);

Console.WriteLine($"{transferMessage} {(transferResult ? "succeed" : "failed")}");
printer.Print(bankAccount);
printer.Print(bankAccount2);

Console.WriteLine("===============Bank work end======================");


Helpers helpers = new Helpers();

string toReverse = "qwertyuiop";
Console.WriteLine($"reverse string : {toReverse}\nreversed state : {helpers.Reverse(toReverse)}");

Console.WriteLine("===============Reverse string end==================");


string toParse = "Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru";

List<string> emails = new List<string>();

helpers.SearchMail(ref toParse, emails.Add);

foreach (var email in emails)
    Console.WriteLine(email);

Console.WriteLine("===============Emails parse end==================");