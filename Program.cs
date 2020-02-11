using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      //EPIC: Updated to be Rock, Paper, Scissors, Lizard, Spock

      //Welcome Message To The User
      Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");

      //Initialize loop boolean variable
      var continuePlaying = true;

      //ADVENTURE: Allow the user to play again (while loop)
      while (continuePlaying)
      {
        //ADVENTURE: Allow user to select Easy, Normal or Impossible difficulty
        Console.WriteLine("This game has 3 difficulties! You can pick Easy, Normal or Impossible!");
        Console.WriteLine("Please enter the difficulty you wish to play:");

        //Read user difficulty selection
        var difficulty = Console.ReadLine().ToLower();

        //Add verification to ensure a valid difficulty is selected
        while (difficulty != "easy" && difficulty != "normal" && difficulty != "impossible")
        {
          Console.WriteLine("You have entered an invalid difficulty level. Please enter a valid difficulty level.");

          Console.WriteLine("Available difficulties are: Easy, Normal or Impossible.");

          difficulty = Console.ReadLine().ToLower();
        }

        //Display difficulty selected
        Console.WriteLine("You have selected " + difficulty + " difficulty level!");

        //Display the options available to pick (Rock, Paper, Scissors, Lizard and Spock)
        Console.WriteLine("Available selections: Rock, Paper, Scissors, Lizard and Spock.");

        //Ask the user to input their choice
        Console.WriteLine("Please enter your selection:");

        //Read user input
        var userSelection = Console.ReadLine().ToLower();

        //Add validation to ensure a correct input is given
        while (userSelection != "rock" && userSelection != "paper" && userSelection != "scissors" &&
               userSelection != "lizard" && userSelection != "spock")
        {
          Console.WriteLine("You have entered an invalid selection. Please choose from Rock, Paper, Scissors, Lizard and Spock.");

          Console.WriteLine("Please enter your selection:");

          userSelection = Console.ReadLine().ToLower();
        }

        //Initialize computer choice variable and get computers choice
        var strComputerChoice = getComputerSelection(userSelection, difficulty);

        //Display the computers choice
        Console.WriteLine("The computer has selected: " + strComputerChoice);

        //Initialize result strings
        var userResult = "";
        var resultString = "";

        //Determine the winner
        if (userSelection == "rock")
        {
          if (strComputerChoice == "rock")
          {
            userResult = "tied";
            resultString = "Rock ties with Rock.";
          }
          else if (strComputerChoice == "paper")
          {
            userResult = "lost";
            resultString = "Paper covers Rock.";
          }
          else if (strComputerChoice == "scissors")
          {
            userResult = "won";
            resultString = "Rock breaks Scissors.";
          }
          else if (strComputerChoice == "lizard")
          {
            userResult = "won";
            resultString = "Rock crushes Lizard.";
          }
          else if (strComputerChoice == "spock")
          {
            userResult = "lose";
            resultString = "Spock vaporizes Rock.";
          }
        }
        else if (userSelection == "paper")
        {
          if (strComputerChoice == "rock")
          {
            userResult = "won";
            resultString = "Paper covers Rock";
          }
          else if (strComputerChoice == "paper")
          {
            userResult = "tied";
            resultString = "Paper ties with Paper.";
          }
          else if (strComputerChoice == "scissors")
          {
            userResult = "lost";
            resultString = "Scissors cuts Paper.";
          }
          else if (strComputerChoice == "lizard")
          {
            userResult = "lost";
            resultString = "Lizard eats Paper.";
          }
          else if (strComputerChoice == "spock")
          {
            userResult = "won";
            resultString = "Paper disproves Spock.";
          }
        }
        else if (userSelection == "scissors")
        {
          if (strComputerChoice == "rock")
          {
            userResult = "lost";
            resultString = "Rock crushes Scissors.";
          }
          else if (strComputerChoice == "paper")
          {
            userResult = "won";
            resultString = "Scissors cuts Paper.";
          }
          else if (strComputerChoice == "scissors")
          {
            userResult = "tied";
            resultString = "Scissors ties with Scissors.";
          }
          else if (strComputerChoice == "lizard")
          {
            userResult = "won";
            resultString = "Scissors decapitates Lizard.";
          }
          else if (strComputerChoice == "spock")
          {
            userResult = "lost";
            resultString = "Spock smashes Scissors.";
          }
        }
        else if (userSelection == "lizard")
        {
          if (strComputerChoice == "rock")
          {
            userResult = "lost";
            resultString = "Rock crushes Lizard.";
          }
          else if (strComputerChoice == "paper")
          {
            userResult = "won";
            resultString = "Lizard eats Paper";
          }
          else if (strComputerChoice == "scissors")
          {
            userResult = "lost";
            resultString = "Scissors decapitate Lizard.";
          }
          else if (strComputerChoice == "lizard")
          {
            userResult = "tied";
            resultString = "Lizard ties with Lizard.";
          }
          else if (strComputerChoice == "spock")
          {
            userResult = "won";
            resultString = "Lizard poisons Spock.";
          }
        }
        else if (userSelection == "spock")
        {
          if (strComputerChoice == "rock")
          {
            userResult = "won";
            resultString = "Spock vaporizes Rock.";
          }
          else if (strComputerChoice == "paper")
          {
            userResult = "lost";
            resultString = "Paper disproves Spock.";
          }
          else if (strComputerChoice == "scissors")
          {
            userResult = "won";
            resultString = "Spock crushes Scissors.";
          }
          else if (strComputerChoice == "lizard")
          {
            userResult = "lost";
            resultString = "Lizard poisons Spock.";
          }
          else if (strComputerChoice == "spock")
          {
            userResult = "tied";
            resultString = "Spock ties with Spock.";
          }
        }

        //Display a Win/Lose message
        if (userResult == "won")
        {
          Console.WriteLine("Congratulations! You have won! " + resultString);
        }
        else if (userResult == "lost")
        {
          Console.WriteLine("I'm sorry, you have lost! " + resultString);
        }
        else if (userResult == "tied")
        {
          Console.WriteLine("You and the computer have tied! " + resultString);
        }

        Console.WriteLine("Would you like to play again? Reply Yes or No.");

        var wantsToReplay = Console.ReadLine().ToLower();

        while (wantsToReplay != "yes" && wantsToReplay != "no")
        {
          Console.WriteLine("You have entered an invalid option. Please reply yes or no.");

          wantsToReplay = Console.ReadLine().ToLower();
        }

        if (wantsToReplay == "no")
        {
          continuePlaying = false;
        }
      }

      //Sign off message
      Console.WriteLine("Thank you for playing!");
    }

    static string randomGenerator()
    {
      //Initialize random number 
      Random rnd = new Random();

      //Define array of possible picks for computer
      string[] possibleSelections = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

      //random integer within the bounds of the length of the array
      int computerChoice = rnd.Next(possibleSelections.Length);

      //Return string value from array based on the array index
      return possibleSelections[computerChoice].ToLower();
    }

    static string getComputerSelection(string userInput, string diffMode)
    {
      if (diffMode == "easy")
      {
        if (userInput == "rock")
        {
          return "scissors";
        }
        else if (userInput == "paper")
        {
          return "rock";
        }
        else if (userInput == "scissors")
        {
          return "paper";
        }
        else if (userInput == "lizard")
        {
          return "paper";
        }
        else if (userInput == "spock")
        {
          return "rock";
        }
        else
        {
          return "";
        }
      }
      //Normal Difficulty: Computer selects random option.
      else if (diffMode == "normal")
      {
        return randomGenerator();
      }
      //Impossible Difficulty: Computer always selects winning option.
      else if (diffMode == "impossible")
      {
        if (userInput == "rock")
        {
          return "paper";
        }
        else if (userInput == "paper")
        {
          return "scissors";
        }
        else if (userInput == "scissors")
        {
          return "rock";
        }
        else if (userInput == "lizard")
        {
          return "scissors";
        }
        else if (userInput == "spock")
        {
          return "paper";
        }
        else
        {
          return "";
        }
      }
      else
      {
        return "";
      }
    }
  }
}
