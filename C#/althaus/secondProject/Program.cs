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

/* List<int> accountBalances = new List<int>();
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
} while (menuOption != "5"); */

// Exercises
// ---------
// 1. If the user doesn't enter 1, 2, 3, 4 or 5 when entering a menu option, display the text, "Invalid menu option"
// 2. If the user enters a negative number when adding or subtracting amounts, display an error message instead of adding or subtracting
// 3. If the user enters an account number that doesn't exist, display an error message
// 4. Create a second list called "accountNames". When creating a new account, ask the user for their name. When printing the account
//    balances, also print the user's name.
/* 
Monster myMonster = new Monster();

myMonster.Name = "John";
myMonster.maxHitPoints = 100;

class Monster
{
  public string Name;
  public int maxHitPoints;
  public int currentHitPoints;
  public int strength;
}

 */

/* void PrintMenu()
{
Console.WriteLine("Menu option");
Console.WriteLine("1. Load data");
Console.WriteLine("2. Display data");
Console.WriteLine("3. Quit");
Console.WriteLine("4. Save data");
Console.WriteLine("Enter menu option:");
}
int GetMenuOption()
{
int menuOption;

do
{
PrintMenu();
menuOption = int.Parse(Console.ReadLine());

} while (menuOption < 1 || menuOption > 4);
return menuOption;
}
int Choice = GetMenuOption();
Console.WriteLine("You have chosen option: " + Choice); */

/* Console.Write("This program will sum two chosen numbers\n");
//Console.Write("This program will sum or multiply two chosen numbers\n");

int Sum( int num1, int num2)
{
  int result = num1 + num2;
  return result;
}

int Multiply( int num1, int num2)
{
  int result = num1 * num2;
  return result;
}

Console.WriteLine("Enter the first number");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int y = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("select multiply or addition");
//if()

int calculation = Sum(x, y);
Console.WriteLine("The sum of your two chosen numbers is: \n" + calculation); */


/* int menuOption;
String name = "";

void Menu()
{
Console.WriteLine("Menu option");
Console.WriteLine("1 - Enter name and surname");
Console.WriteLine("2 - Display greeting");
Console.WriteLine("3 - Quit");

Console.WriteLine("Enter menu choice:");
}


do
{
Menu();
menuOption = int.Parse(Console.ReadLine());

if(menuOption == 1)
{
  Console.WriteLine("Please enter your first and second name!");
  name = Console.ReadLine();
}
else if(menuOption == 2)
{
  if (name != null)
  {
  Console.WriteLine("Hello " + name + "!");
  }
  else
  {
  Console.WriteLine("Hello!");
  }
}

} while (menuOption != 3);
return menuOption; */

/* int delay = 2000;
bool key = false;
bool bagOfSand = false;
bool death = false;
bool win = false;
string location;
string itemChoice;
string movement;

Console.WriteLine("You wake up in a unfamiliar house. There are two items in front of you a key and a bag of sand.");
Thread.Sleep(delay);
Console.WriteLine("You can only choose one (don't ask why) which do you choose?");
itemChoice = Console.ReadLine();

if (itemChoice == "key")
{
    key = true;
    Console.WriteLine("You chose to take the key.");
}
if (itemChoice == "bag of sand")
{
    bagOfSand = true;
    Console.WriteLine("You chose to take the bag of sand.");
}

Console.WriteLine("You exit the room.");
Hallway();

do
{
    Console.WriteLine("Which direction do you want to take?");
    movement = Console.ReadLine();
    Directions();
}
while (death || win);

void Directions()
{
    if (movement.ToLower() == "left" && location == "Hallway")
    {
        Room();
    }
    else if (movement.ToLower() == "right" && location == "Hallway")
    {
        Door();
    }

    if (movement.ToLower() == "right" && location == "Room")
    {
        Hallway();
    }
}

void Hallway()
{
    location = "Hallway";
    Console.WriteLine("You are in a hallway.");
    Console.WriteLine("You see a door to your LEFT and a staircase to your RIGHT heading downwards.");
}

void Room()
{
    location = "Room";
    Console.WriteLine("You are in a well decorated room.");
    Console.WriteLine("You see only one item that looks useful. It's a");
}

void Door()
{
    location = "Door";

    if (movement == "left" && key == true)
    {
        Console.WriteLine("You go down the stairs and hide from the globin. Then use the key to open the door.");
        Thread.Sleep(delay);
        Console.WriteLine("Well Done! You escaped!");
        win = true;
    }
    else if (movement == "left" && bagOfSand == true)
    {
        Console.WriteLine("You go down stairs and throw sand in the goblins face. The door behind the goblin is locked.");
        Console.WriteLine("The goblin is getting back up");
        Console.WriteLine("You can stand and fight(attack) or run back upstairs(up)");
    }
    if (movement == "attack")
    {
        Console.WriteLine("You're not strong enough to fight with your bare hands. You are eaten by the goblin.");
        death = true;
    }
    if (movement == "up")
    {
        Console.WriteLine("You run upstairs before the goblin gets up.");
        Hallway();
    }
} */

/* int[] myInts = [2, 6, 4, 23, 54, 67, 4, 46, 2];
int index = 0;
do{
  Console.WriteLine("Enter an index:");
  string userInput = Console.ReadLine();

try
{
  index = int.Parse(userInput);
}
catch (Exception)
{
  Console.WriteLine($"You entered: {index}");
}
}
while(index == 0);
Console.WriteLine($"The number at index {index} is {myInts[index]}"); */

//LinearSearch
int LinearSearch(List<int> numbers, int numberToFind)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] == numberToFind)
        {
            return i;
        }
    }
    return -1;
}

List<int> sortedNumbers = [3, 6, 9, 14, 19, 25, 28, 34, 41, 56, 58, 86, 89, 93, 97];
int index = LinearSearch(sortedNumbers, 19); // Should return 4 (remember indexes start at 0)

// private static void BinarySearch(int[] args, int targetVal)
// {
//   int left = 0, right = args.Length, middle = 0;
//   while (left right)
//   {
//     middle (left + right) / 2;
//     if (targetVal = args[middle])
//     {
//       Console.WriteLine("Target found: + targetVal+ at index position: + middle); Console.ReadLine()");
//     }
// return;

// else if (targetVal> args[middle])
// }
// {
// left middle + 1;
// }
// else
// {
// right middle - 1;
// }
// }
// Console.WriteLine("Target not found in array"); Console.ReadLine();

// using System;

// // Bubble sort
// public class Bubble_Sort  
// {  
//     public static void Main(string[] args)
//     { 
//         int[] a = { 3, 0, 2, 5, -1, 4, 1 }; // Initializing an array with values
//         int t; // Temporary variable for swapping

//         Console.WriteLine("Original array :");
//         foreach (int aa in a) // Loop to display the original array elements                     
//             Console.Write(aa + " "); // Printing each element of the array

//         for (int p = 0; p <= a.Length - 2; p++) // Outer loop for passes
//         {
//             for (int i = 0; i <= a.Length - 2; i++) // Inner loop for comparison and swapping
//             {
//                 if (a[i] > a[i + 1]) // Checking if the current element is greater than the next element
//                 {
//                     t = a[i + 1]; // Swapping elements if they are in the wrong order
//                     a[i + 1] = a[i];
//                     a[i] = t;
//                 }
//             } 
//         }

//         Console.WriteLine("\n"+"Sorted array :");
//         foreach (int aa in a) // Loop to display the sorted array elements                     
//             Console.Write(aa + " "); // Printing each element of the sorted array

//         Console.Write("\n"); // Adding a new line at the end
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace Selection_Sort
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an instance of the Selection_Sort class with an array of 10 random numbers
//             Selection_Sort selection = new Selection_Sort(10);

//             // Call the Sort method of the Selection_Sort class to perform selection sort
//             selection.Sort();
//         }
//     }

//     class Selection_Sort
//     {
//         private int[] data;
//         private static Random generator = new Random();

//         // Constructor to create an array of specified size filled with random numbers
//         public Selection_Sort(int size)
//         {
//             data = new int[size];

//             // Fill the array with random numbers between 20 and 90
//             for (int i = 0; i < size; i++)
//             {
//                 data[i] = generator.Next(20, 90);
//             }
//         }

//         // Method to perform selection sort
//         public void Sort()
//         {
//             // Display the original array elements before sorting
//             Console.Write("\nSorted Array Elements :(Step by Step)\n\n");
//             display_array_elements();

//             int smallest;

//             // Iterate through the array to perform selection sort
//             for (int i = 0; i < data.Length - 1; i++)
//             {
//                 smallest = i;

//                 // Find the index of the smallest element in the unsorted part of the array
//                 for (int index = i + 1; index < data.Length; index++)
//                 {
//                     if (data[index] < data[smallest])
//                     {
//                         smallest = index;
//                     }
//                 }

//                 // Swap the current element with the smallest element found
//                 Swap(i, smallest);

//                 // Display array elements after each swap (step-by-step)
//                 display_array_elements();
//             }
//         }

//         // Method to swap two elements in the array
//         public void Swap(int first, int second)
//         {
//             int temporary = data[first];
//             data[first] = data[second];
//             data[second] = temporary;
//         }

//         // Method to display array elements
//         public void display_array_elements()
//         {
//             // Display each element of the array
//             foreach (var element in data)
//             {
//                 Console.Write(element + " ");
//             }
//             Console.Write("\n\n");
//         }
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace CommonInsertion_Sort
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an array of integers for sorting
//             int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

//             // Display original array elements
//             Console.WriteLine("\nOriginal Array Elements :");
//             PrintIntegerArray(numbers);

//             // Perform Insertion Sort and display the sorted array elements
//             Console.WriteLine("\nSorted Array Elements :");
//             PrintIntegerArray(InsertionSort(numbers));
//             Console.WriteLine("\n");
//         }

//         // Method implementing Insertion Sort algorithm
//         static int[] InsertionSort(int[] inputArray)
//         {
//             for (int i = 0; i < inputArray.Length - 1; i++)
//             {
//                 for (int j = i + 1; j > 0; j--)
//                 {
//                     // Swap if the element at j - 1 position is greater than the element at j position
//                     if (inputArray[j - 1] > inputArray[j])
//                     {
//                         int temp = inputArray[j - 1];
//                         inputArray[j - 1] = inputArray[j];
//                         inputArray[j] = temp;
//                     }
//                 }
//             }
//             return inputArray; // Return the sorted array
//         }

//         // Method to print integer array elements
//         public static void PrintIntegerArray(int[] array)
//         {
//             foreach (int i in array)
//             {
//                 Console.Write(i.ToString() + "  "); // Display each element followed by a space
//             }
//         }
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace Merge_sort
// {    
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Initialize lists for unsorted and sorted elements
//             List<int> unsorted = new List<int>();
//             List<int> sorted;

//             // Create a random number generator
//             Random random = new Random();

//             Console.WriteLine("Original array elements:");
//             // Generate and display random unsorted elements
//             for(int i = 0; i < 10; i++)
//             {
//                 unsorted.Add(random.Next(0, 100)); // Add a random number to the unsorted list
//                 Console.Write(unsorted[i] + " "); // Display the added number
//             }
//             Console.WriteLine();

//             // Perform Merge Sort on the unsorted list
//             sorted = MergeSort(unsorted);

//             // Display the sorted array elements
//             Console.WriteLine("Sorted array elements:");
//             foreach (int x in sorted)
//             {
//                 Console.Write(x + " ");
//             }
// 			Console.Write("\n");
//         }
		
//         // Method to perform Merge Sort
//         private static List<int> MergeSort(List<int> unsorted)
//         {
//             if (unsorted.Count <= 1)
//                 return unsorted; // Base case: return the list if it has only one element

//             // Divide the unsorted list into two halves
//             List<int> left = new List<int>();
//             List<int> right = new List<int>();

//             int middle = unsorted.Count / 2;
//             for (int i = 0; i < middle; i++) // Split the unsorted list into left
//             {
//                 left.Add(unsorted[i]);
//             }
//             for (int i = middle; i < unsorted.Count; i++) // Split the unsorted list into right
//             {
//                 right.Add(unsorted[i]);
//             }

//             // Recursively perform Merge Sort on the divided lists
//             left = MergeSort(left);
//             right = MergeSort(right);

//             // Merge the sorted halves
//             return Merge(left, right);
//         }

//         // Method to merge two sorted lists
//         private static List<int> Merge(List<int> left, List<int> right)
//         {
//             List<int> result = new List<int>();

//             // Compare elements from both lists and merge them in sorted order
//             while (left.Count > 0 || right.Count > 0)
//             {
//                 if (left.Count > 0 && right.Count > 0)
//                 {
//                     if (left.First() <= right.First()) // Compare the first elements of both lists
//                     {
//                         result.Add(left.First());
//                         left.Remove(left.First()); // Remove the added element from the list
//                     }
//                     else
//                     {
//                         result.Add(right.First());
//                         right.Remove(right.First()); // Remove the added element from the list
//                     }
//                 }
//                 else if (left.Count > 0)
//                 {
//                     result.Add(left.First());
//                     left.Remove(left.First());
//                 }
//                 else if (right.Count > 0)
//                 {
//                     result.Add(right.First());
//                     right.Remove(right.First());
//                 }
//             }
//             return result; // Return the merged and sorted list
//         }
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace Quick_Sort
// {
//     class Program
//     {
//         // Method to perform Quick Sort on an array
//         private static void Quick_Sort(int[] arr, int left, int right) 
//         {
//             // Check if there are elements to sort
//             if (left < right)
//             {
//                 // Find the pivot index
//                 int pivot = Partition(arr, left, right);

//                 // Recursively sort elements on the left and right of the pivot
//                 if (pivot > 1) {
//                     Quick_Sort(arr, left, pivot - 1);
//                 }
//                 if (pivot + 1 < right) {
//                     Quick_Sort(arr, pivot + 1, right);
//                 }
//             }
//         }

//         // Method to partition the array
//         private static int Partition(int[] arr, int left, int right)
//         {
//             // Select the pivot element
//             int pivot = arr[left];

//             // Continue until left and right pointers meet
//             while (true) 
//             {
//                 // Move left pointer until a value greater than or equal to pivot is found
//                 while (arr[left] < pivot) 
//                 {
//                     left++;
//                 }

//                 // Move right pointer until a value less than or equal to pivot is found
//                 while (arr[right] > pivot)
//                 {
//                     right--;
//                 }

//                 // If left pointer is still smaller than right pointer, swap elements
//                 if (left < right)
//                 {
//                     if (arr[left] == arr[right]) return right;

//                     int temp = arr[left];
//                     arr[left] = arr[right];
//                     arr[right] = temp;
//                 }
//                 else 
//                 {
//                     // Return the right pointer indicating the partitioning position
//                     return right;
//                 }
//             }
//         }

//         static void Main(string[] args)
//         {
//             int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

//             Console.WriteLine("Original array : ");
//             foreach (var item in arr)
//             {
//                 Console.Write(" " + item);    
//             }
//             Console.WriteLine();

//             // Call Quick Sort to sort the array
//             Quick_Sort(arr, 0, arr.Length-1);

//             Console.WriteLine();
//             Console.WriteLine("Sorted array : ");

//             foreach (var item in arr)
//             {
//                 Console.Write(" " + item);
//             }
//             Console.WriteLine();
//         }
//     }
// }