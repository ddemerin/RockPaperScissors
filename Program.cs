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
    //Present user with options "Rock", "Paper", or "Scissors"
      // EPIC MODE -- Add "Spock" and "Lizard"
    if (difficulty == "normal") {
      Console.WriteLine("Please pick your weapon of choice: Rock, Paper, Scissors, "
      + "Spock, or Lizard!");
      var choice = Console.ReadLine().ToLower();
      //Add validation around user input
        if (choice != "rock" && choice != "paper" && choice != "scissors" && choice != "spock" && choice != "lizard"){
          Console.WriteLine("You can't play the game with that. Please choose again: " 
          + "Rock, Paper, Scissors, Spock, or Lizard?");
          choice = Console.ReadLine().ToLower();
        }
      //Computer should randomly decide one of the options
      Random random1 = new Random();
      string[] oppChoice = {"rock", "paper", "scissors", "spock", "lizard"};
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
        } else if (choice == "lizard" && opponent == "lizard") {
          Console.WriteLine("No winners! It's a draw!");
        } else if (choice == "spock" && opponent == "spock") {
          Console.WriteLine("No winners! It's a draw!");
        } else if (choice == "paper" && opponent == "rock") {
          Console.WriteLine("Paper covers rock! You win!");
        } else if (choice == "paper" && opponent == "spock") {
          Console.WriteLine("Paper disproves spock! You win!");
        } else if (choice == "rock" && opponent == "scissors") {
          Console.WriteLine("Rock crushes scissors! You win!");
        } else if (choice == "rock" && opponent == "lizard") {
          Console.WriteLine("Rock crushes lizard! You win!");
        } else if (choice == "scissors" && opponent == "paper") {
          Console.WriteLine("Scissors cuts paper! You win!");
        } else if (choice == "scissors" && opponent == "lizard") {
          Console.WriteLine("Scissors decapitates lizard! You win!");
        } else if (choice == "spock" && opponent == "rock") {
          Console.WriteLine("Spock vaporizes rock! You win!");
        } else if (choice == "spock" && opponent == "scissors") {
          Console.WriteLine("Spock smashes scissors! You win!");
        } else if (choice == "lizard" && opponent == "spock") {
          Console.WriteLine("Lizard poisons spock! You win!");
        } else if (choice == "lizard" && opponent == "paper") {
          Console.WriteLine("Lizard eats paper! You win!");
        } else if (choice == "paper" && opponent == "scissors") {
          Console.WriteLine("Scissors cuts paper! You lose!");
        } else if (choice == "paper" && opponent == "lizard") {
          Console.WriteLine("Lizard eats paper! You lose!");
        } else if (choice == "scissors" && opponent == "rock") {
          Console.WriteLine("Rock crushes scissors! You lose!");
        } else if (choice == "scissors" && opponent == "spock") {
          Console.WriteLine("Spock smashes scissors! You lose!");
        } else if (choice == "rock" && opponent == "paper") {
          Console.WriteLine("Paper covers rock! You lose!");
        } else if (choice == "rock" && opponent == "spock") {
          Console.WriteLine("Spock vaporizes rock! You lose!");
        }
      //User should see the randomly selected option, as well as win or lose message
    
    //Easy mode -- computer will always lose
    } else if (difficulty == "easy") {
        Console.WriteLine("Please pick your weapon of choice: Rock, Paper, Scissors, Lizard, or Spock!");
      var choice = Console.ReadLine().ToLower();
     //Add validation around user input
      if (choice != "rock" && choice != "paper" && choice != "scissors" && choice != "spock" && choice != "lizard"){
          Console.WriteLine("You can't play the game with that. Please choose again: " 
          + "Rock, Paper, Scissors, Spock, or Lizard?");
          choice = Console.ReadLine().ToLower();
      }
      //EPIC MODE -- Add Spock and Lizard
        if (choice == "rock") {
          Random random1 = new Random();
          string[] oppChoice = {"scissors", "lizard"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("Your opponent chose {0}", oppChoice[mIndex] + "! You win!");
          var opponent = oppChoice[mIndex];
        } else if (choice == "scissors") {
          Random random1 = new Random();
          string[] oppChoice = {"paper", "lizard"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("Your opponent chose {0}", oppChoice[mIndex] + "! You win!");
          var opponent = oppChoice[mIndex];
        } else if (choice == "paper") {
          Random random1 = new Random();
          string[] oppChoice = {"rock", "spock"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("Your opponent chose {0}", oppChoice[mIndex] + "! You win!");
          var opponent = oppChoice[mIndex];
        } else if (choice == "spock") {
          Random random1 = new Random();
          string[] oppChoice = {"rock", "scissors"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("Your opponent chose {0}", oppChoice[mIndex] + "! You win!");
      }
      
    //Impossible mode -- computer will always win
    } else if (difficulty == "impossible") {
        Console.WriteLine("Please pick your weapon of choice: Rock, Paper, Scissors, Lizard, or Spock!");
      var choice = Console.ReadLine().ToLower();
    //Add validation around user input
      if (choice != "rock" && choice != "paper" && choice != "scissors" && choice != "spock" && choice != "lizard"){
          Console.WriteLine("You can't play the game with that. Please choose again: " 
          + "Rock, Paper, Scissors, Spock, or Lizard?");
          choice = Console.ReadLine().ToLower();
      }
        if (choice == "rock") {
          Random random1 = new Random();
          string[] oppChoice = {"paper", "spock"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("HA! Your opponent chose {0}", oppChoice[mIndex] + " You lose! There's a reason why it's impossible!");
        } else if (choice == "paper") {
         Random random1 = new Random();
          string[] oppChoice = {"lizard", "scissors"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("HA! Your opponent chose {0}", oppChoice[mIndex] + " You lose! There's a reason why it's impossible!");
        } else if (choice == "scissors") {
         Random random1 = new Random();
          string[] oppChoice = {"rock", "spock"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("HA! Your opponent chose {0}", oppChoice[mIndex] + " You lose! There's a reason why it's impossible!");
        } else if (choice == "spock") {
         Random random1 = new Random();
          string[] oppChoice = {"paper", "lizard"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("HA! Your opponent chose {0}", oppChoice[mIndex] + " You lose! There's a reason why it's impossible!");
        }  else if (choice == "lizard") {
         Random random1 = new Random();
          string[] oppChoice = {"scissors", "rock"};
          int mIndex = random1.Next(oppChoice.Length);
          Console.WriteLine("HA! Your opponent chose {0}", oppChoice[mIndex] + " You lose! There's a reason why it's impossible!");
        }
    }
      Console.WriteLine("Would you like to play again? Yes or No?");
      var repeat = Console.ReadLine().ToLower();
      if (repeat != "yes" && repeat != "no"){
          Console.WriteLine("That's not an answer! Would you like to play again? Yes or No?");
          repeat = Console.ReadLine().ToLower();
      } else if (repeat == "no") {
        Console.WriteLine("Thanks for playing!");
        playing = false;
      }
    };      
   }
  }
}