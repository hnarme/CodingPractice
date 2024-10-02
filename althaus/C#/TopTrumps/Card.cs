
using System;

namespace TopTrumpsGame
{
    // The Card class represents a single card in the game. 3 references

    public class Card
    {

        // Input/Output: Properties to store and retrieve card data.
        public string Name { get; set; } // Name of the card (e.g., an animal).
        public int Speed { get; set; } // Speed attribute.
        public int Strength { get; set; } // Strength attribute.
        public int Intelligence { get; set; } // Intelligence attribute.

        // Variables: Constructor to initialize the card with specific values. O references
        public Card(string name, int speed, int strength, int intelligence)
        {
            Name = name;
            Speed = speed;
            Strength = strength;
            Intelligence = intelligence;
        }
        // Procedures: Method to display the card's attributes.
        public void DisplayCard()
        {
            Console.WriteLine($"Name: {Name}"); Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }

        // Algorithms: Compare a specific attribute of two cards.
        public static int Compare(Card card1, Card card2, string attribute)
        {
            switch (attribute.ToLower())
            {
                case "speed":
                    return card1.Speed.CompareTo(card2.Speed);
                case "strength":
                    return card1.Strength.CompareTo(card2.Strength);
                case "intelligence":
                    return card1.Intelligence.CompareTo(card2.Intelligence);
                default:
                    throw new ArgumentException("Invalid attribute");
            }
        }
    }
}