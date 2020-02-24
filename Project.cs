using System;
using System.Collections.Generic;
using System.Linq;

class Riddle {
  static string ChooseRiddle (Dictionary<string, string> riddles) {
    Random rand = new Random ();
    int randNum = rand.Next (0, 6);
    List<String> myKeys = riddles.Keys.ToList ();
    string solution = myKeys[randNum];
    return solution;
  }

  static bool CheckInput (string solution) {
    string input = Console.ReadLine ().ToLower ();
    if (input.Contains (solution)) {
      return true;
    } else {
      return false;
    }
  }

  static void TellAndCheckRiddle (Dictionary<string, string> riddles) {
    bool gameOn = true;
    List<String> usedSolutions = new List<String> { };
    while (gameOn) {
      string solution = ChooseRiddle (riddles);
      if (!usedSolutions.Contains (solution)) {
        Console.WriteLine (riddles[solution]);
        if (CheckInput (solution)) {
          Console.WriteLine ("Correct!");
          usedSolutions.Add (solution);
          if (usedSolutions.Count == riddles.Count) {
            Console.WriteLine ("Congrats! You beat the sphinx!");
            gameOn = false;
          }
        } else {
          Console.WriteLine ("Game Over! The answer was " + solution + ". You were eaten by the sphinx.");
          gameOn = false;
        }
      }

    }
  }

  static void Main () {
    Dictionary<string, string> riddles = new Dictionary<string, string> () { { "footsteps", "The more you take, the more you leave behind. What am I?" }, { "reflection", "You can see me in water, but I never get wet. What am I?" }, { "breath", "What is harder to catch the faster you run?" }, { "name", "What belongs to you but others use it more than you do?" }, { "stamp", "What can travel around the world while staying in a corner?" }, { "cold", "What can you catch but not throw?" }
    };
    Console.WriteLine ("WELCOME TO THE RIDDLE SPHINX");
    TellAndCheckRiddle (riddles);
  }
}