
using Homework;

var functions = new MatrixFunctions();

int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

functions.GetSummOfDiagonalsElements(matrix);
functions.GetSummOfDiagonalsElements(matrix2);

var bankAccount = new BankAccount();

bankAccount.AddMoney(200.77f);
bankAccount.GetAmount();
bankAccount.WithdrawMoney(-500);
bankAccount.WithdrawMoney(300);
bankAccount.WithdrawMoney(150);
bankAccount.GetAmount();
bankAccount.WithdrawMoney(150);
bankAccount.AddMoney(50, 6);
bankAccount.GetAmount();

var worker1 = new WorkerPublic();
worker1.name = "John";
worker1.age = 25;
worker1.salary = 1000;

var worker2 = new WorkerPublic();
worker2.name = "Sam";
worker2.age = 26;
worker2.salary = 2000;

var sumSalaries = worker1.salary + worker2.salary;
var sumAge = worker1.age + worker2.age;
Console.WriteLine(sumSalaries);
Console.WriteLine(sumAge);

var worker3 = new WorkerPrivate();
worker3.SetName("John");
worker3.SetAge(25);
worker3.SetSalary(1000);

var worker4 = new WorkerPrivate();
worker4.SetName("Sam");
worker4.SetAge(26);
worker4.SetSalary(2000);

var sumSalaries2 = worker3.GetSalary() + worker4.GetSalary();
var sumAge2 = worker3.GetAge() + worker4.GetAge();
Console.WriteLine(sumSalaries2);
Console.WriteLine(sumAge2);

worker4.SetAge(-5);
Console.WriteLine(worker4.GetAge());

