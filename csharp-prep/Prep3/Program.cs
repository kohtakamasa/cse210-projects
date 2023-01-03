using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        /* 
        Overview
            In the Guess My Number game the computer picks a magic
            number, and then the user tries to guess it. After each 
            guess, the computer tells the user to guess "higher" or 
            "lower" until they guess the magic number.

            This assignment is a little tricky, because it brings 
            together many of the concepts you've learned in this course 
            including loops and if statements.
        */
        // Part 1 & 2
        // Console.Write("What is the magic number? ");
        // int magicNum = int.Parse(Console.ReadLine());
        
        // part 3, use random number generator
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);
        
        int guessNum = 0;
        while (guessNum != magicNum)
        {
            Console.Write("What is your guess? ");
            guessNum = int.Parse(Console.ReadLine());

            if (guessNum == magicNum)
            {
                Console.WriteLine("You guessed it!");
            } 
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }
        }






        /* NOTES
        LOOPS
        - while
            string input = "yes";
            while (input == "yes")
            {
                Console.Write("Do you want to continue? ");
                input = Console.ReadLine();
            }

        - do-while (NOT part of Python)
            string input; 
            do 
            {
                Console.Write("Do you want to continue? );
                input = Console.ReadLine();
            } while (input == "yes");
            
        - for 
            - The condition has three parts, separated by semi-colons. 
                - The first initializes the value
                - the second is the condition to check
                - the third is an increment step that is run at the end of each loop
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }
            
            - Count to 2 to 20 by two 
            for (int i=0; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }

        - foreach (similar to for loop in Python)
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

        - Random Numbers
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
        */

    }
}