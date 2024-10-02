using System.Reflection.Metadata.Ecma335;

class Person

{
    public string Name;
    public string FavouriteFruit;

    public void DisplayGreeting(Person person)
    {
        Name = person.Name;

        FavouriteFruit = person.FavouriteFruit;

        Console.WriteLine($"Hello {person.Name}. Your favourite fruit is {person.FavouriteFruit}");
    }
}