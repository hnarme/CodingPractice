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

List<string> fruits;
fruits = new List<string>();
fruits[0] = "Apple";
fruits[1] = "Banana";
fruits[2] = "Cherry";

foreach (string myString in fruits)
{
    Console.WriteLine(myString);
}

do
{
    Console.WriteLine(fruits);
}
while (fruits.Count > 0);

while (fruits.Count > 0)
{
    Console.WriteLine(fruits + "while loop");
}
