using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    { bool playing = true;
    while (playing == true) {
    //Opens with a message to welcome the user
    Console.WriteLine("Hello, prestigious competitor, to the greatest of game of all time!"
    + " Rock, Paper, Scissors!");
    //Let user choose a difficulty
    Console.WriteLine("Please choose your diffculty: Easy, Normal, or Impossible.");
    var difficulty = Console.ReadLine().ToLower();
    if (difficulty != "easy" && difficulty != "normal" && difficulty != "impossible"){
        Console.WriteLine("That is not a difficulty choice. Please choose again: " 
        + "Easy, Normal, or Impossible?");
        difficulty = Console.ReadLine().ToLower();
    }
    //Present user with options ("Rock", "Paper", or "Scissors")
    if (difficulty == "normal") {
      Console.WriteLine("Please pick your weapon of choice: Rock, Paper, or Scissors!");
      var choice = Console.ReadLine().ToLower();
      //Add validation around user input
        if (choice != "rock" && choice != "paper" && choice != "scissors"){
          Console.WriteLine("You can't play the game with that. Please choose again: " 
          + "Rock, Paper, or Scissors?");
          choice = Console.ReadLine().ToLower();
        }
      //Computer should randomly decide one of the options
      Random random1 = new Random();
      string[] oppChoice = {"rock", "paper", "scissors"};
      int mIndex = random1.Next(oppChoice.Length);
      Console.WriteLine("Your opponent chose {0}", oppChoice[mIndex] + "!");
      var opponent = oppChoice[mIndex];
      //Program should decide who the winner is
        if (choice == "rock" && opponent == "rock") {
          Console.WriteLine("No winners! It's a draw!");
        } else if (choice == "paper" && opponent == "paper") {
          Console.WriteLine("No winners! It's a draw!");
        } else if (choice == "scissors" && opponent == "scissors") {
          Console.WriteLine("No winners! It's a draw!");
        } else if (choice == "paper" && opponent == "rock") {
          Console.WriteLine("You win!");
        } else if (choice == "rock" && opponent == "scissors") {
          Console.WriteLine("You win!");
        } else if (choice == "scissors" && opponent == "paper") {
          Console.WriteLine("You win!");
        } else if (choice == "paper" && opponent == "scissors") {
          Console.WriteLine("You lose!");
        } else if (choice == "scissors" && opponent == "rock") {
          Console.WriteLine("You lose!");
        } else if (choice == "rock" && opponent == "paper") {
          Console.WriteLine("You lose!");
        }
      //User should see the randomly selected option, as well as win or lose message
    
    //Easy mode -- computer will always lose
    } else if (difficulty == "easy") {
        Console.WriteLine("Please pick your weapon of choice: Rock, Paper, or Scissors!");
      var choice = Console.ReadLine().ToLower();
     //Add validation around user input
      if (choice != "rock" && choice != "paper" && choice != "scissors"){
        Console.WriteLine("You can't play the game with that. Please choose again: " 
        + "Rock, Paper, or Scissors?");
        choice = Console.ReadLine().ToLower();
      }
        if (choice == "rock") {
        Console.WriteLine("Your opponent chose scissors! You win!");
        } else if (choice == "scissors") {
        Console.WriteLine("Your opponent chose paper! You win!");
        } else if (choice == "paper") {
        Console.WriteLine("Your opponent chose rock! You win!");
      }
      
    //Impossible mode -- computer will always win
    } else if (difficulty == "impossible") {
        Console.WriteLine("Please pick your weapon of choice: Rock, Paper, or Scissors!");
      var choice = Console.ReadLine().ToLower();
    //Add validation around user input
      if (choice != "rock" && choice != "paper" && choice != "scissors"){
        Console.WriteLine("You can't play the game with that. Please choose again: " 
        + "Rock, Paper, or Scissors?");
        choice = Console.ReadLine().ToLower();
      }
        if (choice == "rock") {
        Console.WriteLine("HA! Your opponent chose paper! You lose! There's a reason why it's impossible!");
        } else if (choice == "paper") {
        Console.WriteLine("HA! Your opponent chose scissors! You lose! There's a reason why it's impossible!");
        } else if (choice == "scissors") {
        Console.WriteLine("HA! Your opponent chose rock! You lose! There's a reason why it's impossible!");
        }
      }
      Console.WriteLine("Would you like to play again? Yes or No?");
      var repeat = Console.ReadLine().ToLower();
      if (repeat != "yes" && repeat != "no"){
          Console.WriteLine("You can't play the game with that. Please choose again: " 
          + "Rock, Paper, or Scissors?");
          repeat = Console.ReadLine().ToLower();
      } else if (repeat == "no") {
        Console.WriteLine("Thanks for playing!");
        playing = false;
      }
    };      
   }
  }
}