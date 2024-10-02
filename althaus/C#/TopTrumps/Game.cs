using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TopTrumpsGame
{
    // The Game class manages the overall game flow.

    public class Game
    {
        private List<Card> deck; // Data Structures: List representing the deck of cards.
        private Player player1; // Player 1.
        private Player player2; // Player 2.

        // Constructor to initialize the game with two players and a deck of cards.
        public Game(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;
            deck = new List<Card>();

            // Alogrithms and Data Structures: Initialize the deck with sample cards.
            InitializeDeck();
            ShuffleDeck();
            DistributeCards();
        }

        // Algorithms: Initialize the deck with cards.
        private void InitializeDeck()
        {
            deck.Add(new Card("Lion", 80, 90, 60));
            deck.Add(new Card("Elephant", 80, 100, 70));
            deck.Add(new Card("Cheetah", 100, 70, 50));
            deck.Add(new Card("Gorilla", 60, 85, 80));
            deck.Add(new Card("Falcon", 95, 40, 65));
            // Add more cards as needed...
        }

        // Algorithms: Shuffle the deck of cards.
        private void ShuffleDeck()
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        // Procedures: Distribute cards between the two players.
        public void DistributeCards()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                if (i % 2 == 0)
                {
                    player1.AddCard(deck[i]);
                }
                else
                {
                    player2.AddCard(deck[i]);
                }
            }
        }

        // Procedures: Start the game.
        public void StartGame()
        {
            Console.WriteLine("Starting the Top Trumps game!");

            // Iteration: Loop until one player has no cards left.
            while (player1.HasCards() && player2.HasCards())
            {
                PlayRound();
            }

            // Selection (If/Else): Determine the winner based on who has the most cards.
            DetermineWinner();
        }

        // Procedures: Handle one round of play.
        private void PlayRound()
        {
            Console.WriteLine($"{player1.Name}, select an attribute to compare: Speed, Strength, Intelligence");
            string attribute = Console.ReadLine();

            Card p1Card = player1.PlayCard();
            Card p2Card = player2.PlayCard();

            Console.WriteLine($"{player1.Name} played:");
            p1Card.DisplayCard();
            Console.WriteLine($"{player2.Name} played:");
            p2Card.DisplayCard();

            int result = Card.Compare(p1Card, p2Card, attribute);

            // Selection (If/Else): Determine the winner of the round.
            if (result > 0)
            {
                Console.WriteLine($"{player1.Name} wins this round!");
                player1.AddCard(p1Card);
                player2.AddCard(p2Card);
            }
            else if (result < 0)
            {
                Console.WriteLine($"{player2.Name} wins this round!");
                player2.AddCard(p1Card);
                player2.AddCard(p2Card);
            }
            else
            {
                Console.WriteLine("It's a tie! No cards are exchanged.");
                player1.AddCard(p1Card);
                player2.AddCard(p2Card);
            }
        }

        // Procedures: Start the game.
        private void DetermineWinner()
        {
            if (player1.Hand.Count > player2.Hand.Count)
            {
                Console.WriteLine($"{player1.Name} wins the game!");
            }
            else if (player1.Hand.Count < player2.Hand.Count)
            {
                Console.WriteLine($"{player2.Name} wins the game!");
            }
            else
            {
                Console.WriteLine("The game is a tie!");
            }
        }

    }
}