using System;

namespace AnimalGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try {

                //Set up a new game
                var game = new Game();
                var animalTree = game.SetUpGame();

                // Traverse the binary tree
                // No - go down left side of tree, yes - go down right side
                var currentNode = animalTree;
                var result = 0;

                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Item);
                    var answer = Console.ReadLine();

                    if (answer == "n")
                    {
                        currentNode = currentNode.SubItems.First;
                        result = 0;
                    }

                    else if (answer == "y")
                    {
                        currentNode = currentNode.SubItems.Second;
                        result = 1;
                    }
                }

                // Display the result, the computer guessed correctly if the last answer is "y"
                Console.WriteLine(game.ShowResult(result));
            }
            catch (Exception ex)
            {
                Console.WriteLine("There has been a problem - '{0}'", ex);
                Environment.Exit(1);
            }

        }
    }
}
