using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        /* 
        For this assignment, write a C# program that has several simple functions:

        DisplayWelcome - Displays the message, "Welcome to the 
        Program!"
        PromptUserName - Asks for and returns the user's name (as a 
        string)
        PromptUserNumber - Asks for and returns the user's favorite 
        number (as an integer)
        SquareNumber - Accepts an integer as a parameter and returns 
        that number squared (as an integer)
        DisplayResult - Accepts the user's name and the squared 
        number and displays them.

        Your Main function should then call each of these functions 
        saving the return values and passing data to them as 
        necessary.
        */

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());

            return num;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"Hi, {name}. The square of your number is {squared}.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();

        int squareNum = SquareNumber(num);
        DisplayResult(name, squareNum);




        /* NOTES
        FUNCTIONS
            - general structure of function 
                returnType FunctionName(dataType parameter1, dataType parameter2)
                {
                    // function_body
                }
            - use TitleCase
            - Need to define return data type (if none --> void)

            void DisplayMessage()
            {
                Console.WriteLine("Hello World");
            }

            void DisplayPersonalMessage(string userName)
            {
                Console.WriteLine($"Hello {userName"});
            }

            int AddNumbers(int first, int second)
            {
                int sum = first + second;
                return sum;
            }

        FUNCTIONS VS METHODS
            - member function is a method
            "If you want to define "regular" standalone function, you 
            need to use the static keyword. This tells C# that you 
            want your functions to be able to be called without any 
            other context."
            
            i.e.
            static void DisplayMessage()
            {
                Console.WriteLine("Hello World);
            }
        
        VARIABLE SCOPE 
            variables declared only in the same body can be used
        */
    }
}