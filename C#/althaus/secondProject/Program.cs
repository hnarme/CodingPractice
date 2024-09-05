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

List<int> accountBalances = new List<int>();
string menuOption;
string userInput;
do
{
  Console.WriteLine("\nMenu\n" +
    "1. Add bank account\n" +
    "2. Add money to account\n" +
    "3. Subtract money from account\n" +
    "4. Print all accounts\n" +
    "5. Quit\n" +
    "Please enter option:");
  menuOption = Console.ReadLine();

  if (menuOption == "1")
  {
    accountBalances.Add(0);
    Console.WriteLine("Add bank account\n" +
    "New bank account created. Account number is " + (accountBalances.Count - 1) + ".\n" +
    "Account balance is £0.00.");
  }
  else if (menuOption == "2")
  {
    Console.WriteLine("Add money to account");
    Console.Write("Enter account number:");
    userInput = Console.ReadLine();
    int accountNumber = int.Parse(userInput);
    Console.Write("Enter amount:");
    userInput = Console.ReadLine();
    float amountDecimal = float.Parse(userInput);
    int amount = (int)(amountDecimal * 100f);
    accountBalances[accountNumber] += amount;
    Console.WriteLine("Account " + accountNumber + " now has £" + (float)accountBalances[accountNumber] / 100f);
  }
  else if (menuOption == "3")
  {
    Console.WriteLine("Subtract money from account");
    Console.Write("Enter account number:");
    userInput = Console.ReadLine();
    int accountNumber = int.Parse(userInput);
    Console.Write("Enter amount:");
    userInput = Console.ReadLine();
    float amountDecimal = float.Parse(userInput);
    int amount = (int)(amountDecimal * 100f);
    accountBalances[accountNumber] -= amount;
    Console.WriteLine("Account " + accountNumber + " now has £" + (float)accountBalances[accountNumber] / 100f);
  }
  else if (menuOption == "4")
  {
    for (int i = 0; i < accountBalances.Count; i++)
    {
      Console.WriteLine("Account " + i + " has £" + (float)(accountBalances[i]) / 100f);
    }
  }
} while (menuOption != "5");

// Exercises
// ---------
// 1. If the user doesn't enter 1, 2, 3, 4 or 5 when entering a menu option, display the text, "Invalid menu option"
// 2. If the user enters a negative number when adding or subtracting amounts, display an error message instead of adding or subtracting
// 3. If the user enters an account number that doesn't exist, display an error message
// 4. Create a second list called "accountNames". When creating a new account, ask the user for their name. When printing the account
//    balances, also print the user's name.