namespace BlackJack
{
    internal class Program
    {
        public static int PlayerCount;
        public static int HandSize;
        static void Main(string[] args)
        {
            for (int i = 1; i >= 0; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("What game would you like to play?\n1) BlackJack\n2) GoFish\n3) Poker\n4)\n");
                }
                string selection = Console.ReadLine() ?? "";
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("How many players are there?\n");
                        PlayerCount = int.Parse(Console.ReadLine() ?? "");
                        playBlackJack();
                        i = 0;
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("How many players are there?\n");
                        PlayerCount = int.Parse(Console.ReadLine() ?? "");
                        Console.WriteLine("How big of hands do you want?\n");
                        string Handsize = Console.ReadLine() ?? "";
                        playGoldFish();
                        i = 0;
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("How many players are there?\n");
                        PlayerCount = int.Parse(Console.ReadLine() ?? "");
                        Handsize = "2";
                        playTexasHoldem();
                        i = 0;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number or name of the game.");
                        break;
                }
            }
        }

        private static void playBlackJack()
        {
            Deck deck = new Deck();
            List<Blackjackhand> blackjackhands = new List<Blackjackhand>();

            for (int i = 0; i < PlayerCount; i++)
            {
                blackjackhands.Add(new Blackjackhand());
            }
            

            deck.Shuffle();
            Console.WriteLine("Welcome to BlackJack!\n\nThe goal of the game is to add your cards together to equal 21, GOODLUCK!");

            while (deck.RemCards() > 0)
            {
                for (int i = 0;i < PlayerCount;i++)
                {
                    Card ShownCard = deck.Draw();
                    if(ShownCard == null) 
                    {
                        break;
                    }
                    Console.WriteLine(ShownCard.ToString());
                    blackjackhands[i].Add(ShownCard);
                    Console.WriteLine($"player {i} hand total: {blackjackhands[i].HandTotal()}");
                }
                Console.WriteLine();

                //for (int player = 1; player <= PlayerCount; player++)
                //{
                //    List<Card> playerHand = deck.DealPlayers(HandSize);
                //    Console.WriteLine($"Player {player}'s Hand:");
                //    foreach (Card card in playerHand)
                //    {
                //        Console.WriteLine(card);
                //    }
                //}
            }

            Console.WriteLine("Thanks for playing!\n\n Press Enter to return to main menu or R to play again!");

            if (string.Equals(Console.ReadLine()?.ToLower(), "r"))
            {
                Console.Clear();
                playBlackJack();
            }
        }
        private static void playGoldFish()
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Console.WriteLine("Welcome to Gofish!\n\nThe goal of this game is to get rid of all the cards in your hand by finding cards that your other oponents also have in their hands!");

            while (deck.RemCards() > 0)
            {
                Card ShownCard = deck.Draw();
                Console.WriteLine(ShownCard.ToString());
                //Console.WriteLine(dealt);
                for (int player = 1; player <= PlayerCount; player++)
                {
                    List<Card> playerHand = deck.DealPlayers(HandSize);
                    Console.WriteLine($"Player {player}'s Hand:");
                    foreach (var card in playerHand)
                    {
                        Console.WriteLine(card);
                    }
                }

            }

            Console.WriteLine("Thanks for playing!\n\n Press Enter to return to main menu or R to play again!");
            if (string.Equals(Console.ReadLine()?.ToLower(), "r"))
            {
                Console.Clear();
                playGoldFish();
            }
        }
        private static void playTexasHoldem()
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Console.WriteLine("Welcome to Texas Hold Em!\n\nYou know what youre doing ;)");

            while (deck.RemCards() > 0)
            {
                Card ShownCard = deck.Draw();
                Console.WriteLine(ShownCard.ToString());
                //Console.WriteLine(dealt);
                for (int player = 1; player <= PlayerCount; player++)
                {
                    List<Card> playerHand = deck.DealPlayers(HandSize);
                    Console.WriteLine($"Player {player}'s Hand:");
                    foreach (var card in playerHand)
                    {
                        Console.WriteLine(card);
                    }
                }

            }
            Console.WriteLine("Thanks for playing!\n\n Press Enter to return to main menu or R to play again!");
            if (string.Equals(Console.ReadLine()?.ToLower(), "r"))
            {
                Console.Clear();
                playTexasHoldem();

            }
        }
    }
}
