using System;
using System.Collections.Generic;

namespace AnimalGame
{
    public class Game
    {
        public Game()
        {
        }

        /// <summary>
        /// Sets up the Animal Game.
        /// Populate a binary tree so that 'no' answers lead down left hand side of tree
        /// and 'yes' answers lead down right hand side of tree 
        /// </summary>
        /// <returns>A Binary Tree representing the questions and possible ansers</returns>

        public BinaryTree<string> SetUpGame()
        {
            // Create tree structure and populate with questions
            var animalTree = new BinaryTree<string>("Think of an animal and I'll guess it.\nDoes it have four legs (y or n)");

            animalTree.SubItems = new Pair<BinaryTree<string>>(
                new BinaryTree<string>("Does it have wings? (y or n)"),
                new BinaryTree<string>("Does it say moo? (y or n)"));
                
            animalTree.SubItems.First.SubItems =
                new Pair<BinaryTree<string>>(
                    new BinaryTree<string>("Does it have a fin? (y or n)"),
                    new BinaryTree<string>("Does it have feathers? (y or n)"));
                    
            animalTree.SubItems.First.SubItems.First.SubItems =
                new Pair<BinaryTree<string>>(
                    new BinaryTree<string>("Is it a jelly fish? (y or n)"),
                    new BinaryTree<string>("Is it a White Pointer? (y or n)"));
                    
            animalTree.SubItems.First.SubItems.Second.SubItems =
                new Pair<BinaryTree<string>>(
                    new BinaryTree<string>("Is it a penguin? (y or n)"),
                    new BinaryTree<string>("Is it Big Bird? (y or n)"));
                    
            animalTree.SubItems.Second.SubItems =
                new Pair<BinaryTree<string>>(
                    new BinaryTree<string>("Does it say eeyore? (y or n)"),
                    new BinaryTree<string>("Is it a cow? (y or n)"));
                    
            animalTree.SubItems.Second.SubItems.First.SubItems =
                new Pair<BinaryTree<string>>(
                    new BinaryTree<string>("Is it a horse? (y or n)"),
                    new BinaryTree<string>("Is it a donkey? (y or n)"));

            return animalTree;
        }

        public string ShowResult(int result)
        {
            string resultMessage = "";
            switch (result)
            {
                case 0:
                    resultMessage = "I'll try harder next time";
                    break;
                case 1:
                    resultMessage = "I am half psychic half computer";
                    break;
                default:
                    break;

            }

            return resultMessage;
        }
    }
}
