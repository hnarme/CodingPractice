Person person = new Person();

//Console.WriteLine("Please type your name!");
//person.Name = Console.ReadLine();
//Console.WriteLine("Please type your favourite fruit!");
//person.FavouriteFruit = Console.ReadLine();

person.Name = "Hannah";
person.FavouriteFruit = "Melon";

Console.Write(person.DisplayGreeting(person.Name, person.FavouriteFruit));