//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BlackJack
//{
//    //internal class BlackJackGame : Program
//    //{

//        //public static void BlackJack()
//        //{
//        //    Deck deck = new Deck();

//        //    List<Blackjackhand> blackjackhands = new List<Blackjackhand>();

//        //    for (int i = 0; i < playerCount; i++)
//        //    {
//        //        blackjackhands.Add(new Blackjackhand());
//        //    }

//        //    deck.Shuffle();
//        //    Console.WriteLine("Welcome to BlackJack!\n\nThe goal of the game is to add your cards together to equal 21, GOODLUCK!");

//        //    while (deck.RemCards() > 0)
//        //    {
//        //        for (int i = 0; i < playerCount; i++)
//        //        {
//        //            Console.WriteLine("Press H to hit or S to stay!");
//        //            string userInput = Console.ReadLine();

//        //            if (userInput.ToUpper() == "H")
//        //            {
//        //                Card ShownCard = deck.Draw();
//        //                if (ShownCard == null)
//        //                {
//        //                    break;
//        //                }
//        //                Console.WriteLine($"You drew a {ShownCard}", ShownCard.ToString());
//        //                blackjackhands[i].Add(ShownCard);
//        //                Console.WriteLine($"player {i + 1}'s new hand total: {blackjackhands[i].HandTotal()}");


//        //                else if (blackjackhands[i].HandTotal() == 21)
//        //                {

//        //                }
//        //            }
//        //            else if (userInput.ToUpper() == "S")
//        //            {
//        //                Console.WriteLine($"Player {i} is staying at: {blackjackhands[i].HandTotal()}");
//        //            }

//        //        }
//        //        Console.WriteLine();
//        //    }
//        //    return;
//        //}
//        //private static void BJWinCheck()
//        //{
//        //    int winCondition = 0;

//        //    if (blackjackhands[i].HandTotal() > 21)
//        //    {
//        //        Console.WriteLine($"\nPlayer {i + 1} busts! Dealer wins.");
//        //        winCondition = 0;
//        //    }
//        //    else if (Blackjackhand)

//        //    switch (winCondition)
//        //    {
//        //        case 0:
//        //        Console.WriteLine("Dealer has won the table");
//        //        blackjackhands.Clear();
//        //        Console.WriteLine(blackjackhands);
//        //        break;

//        //        case 1:
//        //        Console.WriteLine($"Player {i + 1} has won the this table!");
//        //        break;

//        //        case 2:
//        //        Console.WriteLine($"Players (PLACEHOLDER) tied and split the pot!");
//        //            //create condition for multiple people to win a pot, will need temporary variables for each round of players to get an equal amount of turns before a win condition is made
//        //        break;

//        //        default: Console.WriteLine("Error.");
//        //        break;




//        // }
//    }
//    }
//}
