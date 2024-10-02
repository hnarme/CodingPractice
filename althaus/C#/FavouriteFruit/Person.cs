using System.Reflection.Metadata.Ecma335;

class Person

{
    public string Name;
    public string FavouriteFruit;

    public void DisplayGreeting(string Name, string FavouriteFruit)
    {
        Name = Name;
        FavouriteFruit = FavouriteFruit;

        Console.WriteLine($"Hello {Name}. Your favourite fruit is {FavouriteFruit}");
    }
}