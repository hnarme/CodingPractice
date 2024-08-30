// See https://aka.ms/new-console-template for more information
string name;
string age;


Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("Hello " + name + "!");
Console.WriteLine("What is your age?");
age = Console.ReadLine();
Console.WriteLine("Your are " + age + " years old!");
int convertAge = int.Parse(age);
int ageInTenYears = convertAge + 10;
Console.WriteLine("In 10 years time, you will be " + ageInTenYears + " years old!");