using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!"); // With new line
        // Console.Write("Hello World!"); // Without new line

        // Console.WriteLine("");
        // // Unlike python, need to provide prompt before 
        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine(); // This is what allows for user input
        // Console.WriteLine($"Your favorite color is: {color}");

        // /* If Statements
        //    Condition in parentheses
        //    block uses curly races  
        // */
        // int x = 10;
        // int y = 5;
        // if (x > y) 
        // {
        // Console.WriteLine("greater");
        // }

        // //String Interpolation
        // // f string in python... use $ before with C#
        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}.");

        
        /* 
        Overview
        An iconic line from the James Bond 
        movies is that he would introduce 
        himself as "Bond, James Bond." For this 
        assignment you will write a program that 
        asks for your name and repeats it back 
        in this way.

        Assignment
        Prompt the user for their first name. Then, prompt them for 
        their last name. Display the text back all on one line 
        saying, "Your name is last-name, first-name, last-name" as 
        shown: */
        
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}