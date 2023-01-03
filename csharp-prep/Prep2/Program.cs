using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        /* 
        Overview
        Write a program that determines the letter grade for a course according to the following scale:
        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60

        Assignment
        Start by completing the core requirements, then when that part is complete, if you have time, see if you can complete some of the stretch challenges as well.

        Please work through the requirements in order rather than jumping ahead to more complicated steps, to ensure that everyone is following the concepts.
        */
        Console.Write("Please enter your grade percentage: ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);

        string letter = "";

        if (percent >= 90) 
        {
            letter = "A";
        } else if (percent >= 80)
        {
            letter = "B";
        } else if (percent >= 70)
        {
            letter = "C";
        } else if (percent >= 60)
        {
            letter = "D";
        } else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70) 
        {
            Console.WriteLine("Congratulations! You passed the class!");
        } else 
        {
            Console.WriteLine("You didn't pass this time. Keep trying!");
        }
 




        /*  NOTES
        Operators
        == operator to check if two variables are equal
        also uses !=, >=, <= 
        and --> &&
        or --> ||
        not --> !

        use camelCase

        Converting Types
        string valueInText = "42";
        int number = int.Parse(valueInText);

        Console.ReadLine() always returns a string!
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        Convert number to string --> .ToString() function
        int number = 42;
        string textVersion = number.ToString();
         */
    }
}