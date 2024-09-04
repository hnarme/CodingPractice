// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");
int[] myData = new int[5];
myData[0] = 67;
myData[1] = 45;
myData[2] = 34;
myData[3] = 36;
myData[4] = 42;
myData[5] = 45;
int[] myData2 = new int[] { 54, 32, 11, }; */

/* string[] fruits = new string[2];
fruits[0] = "Apple";
fruits[1] = "Banana";
fruits[2] = "Cherry";
Console.WriteLine(fruits[0]);
fruits[2] = "Elderberry";
Console.WriteLine(fruits[2]); 
fruits[2] = "Cherry";
Console.WriteLine(fruits[3]); */

/* List<int> fruits2;
fruits2 = new List<int>();
fruits2.Add(5);
fruits2[0] = 3;
fruits2[1] = 4;
fruits2[2] = 5;
fruits2[3] = 6;
fruits2[4] = 7; */

/* List<string> fruits;
fruits = new List<string>();
fruits[0] = "Apple";
fruits[1] = "Banana";
fruits[2] = "Cherry";
Console.WriteLine(fruits[1]);
fruits[2] = "Elderberry";
Console.WriteLine(fruits[2]);
fruits.Add("Durian");
Console.WriteLine(fruits[3]); */

/* for (int myInt = 0; myInt < 10; myInt++)
{
    Console.WriteLine(myInt);
} */

/* int[] myInts = new int[10];

foreach (int myInt in myInts)
{
    Console.WriteLine(myInts);
} */

/* List<string> fruits;
fruits = new List<string>();
fruits[0] = "Apple";
fruits[1] = "Banana";
fruits[2] = "Cherry";

foreach (string myString in fruits)
{
    Console.WriteLine(myString);
} */

/* do
{
    Console.WriteLine(fruits);
}
while (fruits.Count > 0); */

/* while (fruits.Count > 0)
{
    Console.WriteLine(fruits + "while loop");
} */

/* string input;
string[] fruits = new string[] {}
do
{
    console.WriteLine("Please type a fruit!");
    input = Console.ReadLine();
    fruits.Add(input);
}
while(input != "quit"); */

/* List<string> fruits = new List<string>();
string fruitEntered;
do
{
  Console.WriteLine("Please enter a number between the name of a fruit:");
  fruitEntered = Console.ReadLine();
  if (fruitEntered != "quit")
  {
    fruits.Add(fruitEntered);
  }
} while (fruitEntered != "quit");
// Output all fruits in the list named "fruits"
foreach (string fruit in fruits)
{
  Console.WriteLine(fruit);
} */

List<int> userAccountID = new List<int>();
int choice;
int accountNum = 0;
int balanceInPence = 0;

//
Console.WriteLine("Menu");
Console.WriteLine("1. Add bank account");
Console.WriteLine("2. Add money to account");
Console.WriteLine("3. Subtract money from account");
console.WriteLine("4. Print all accounts")
console.WriteLine("Please enter option: ")
choice = Console.ReadLine();

//
if(choice == 1)
{
    accountNum = accountNum + 1;
    accounts.Add(accountNum);
    Console.WriteLine("Add bank account");
    Console.WriteLine("New bank account created");
    Console.WriteLine("Account number is " + userAccountID);

    for (int i = 0; i > balanceInPence; i++)
    {
        balanceInPence = balanceInPence + 1;
        console.WriteLine("Account balance is £" + (float)(balanceInPence) / 100.0f);
    }
}
else if(choice == 2)
{
    console.WriteLine("How much would you like to add")
    addMoneyChoice = Console.ReadLine();
}
else if(choice == 3)
{
    console.WriteLine("Under maintenance choose option 1")
    choice = Console.ReadLine();
}
else if(choice == 4)
{
    foreach (int accounts in userAccountID)
    {
        Console.WriteLine(accounts);
    }
}
else
{
    console.writeLine("Invalid choice! You must only select one of the menu options using numerical values!");
}