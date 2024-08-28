// See https://aka.ms/new-console-template for more information
int delay = 1000;
string name;
string fruit;

Console.WriteLine("What is your name");
name = Console.ReadLine();
Console.WriteLine("Computer loading.");
Thread.Sleep(delay);
Console.WriteLine("Computer loading..");
Thread.Sleep(delay);
Console.WriteLine("What is your favourite fruit");
fruit = Console.ReadLine();
Console.WriteLine("Computer loading...");
Thread.Sleep(delay);
Console.WriteLine("Computer loading....");
Thread.Sleep(delay);
Console.WriteLine("Load complete");

Console.WriteLine("Hello " + name + " I think your favourite fruit " + fruit + " is great!");