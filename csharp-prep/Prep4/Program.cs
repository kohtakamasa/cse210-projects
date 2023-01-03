using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        /*  
        Assignment
            Ask the user for a series of numbers, and append each one 
            to a list. Stop when they enter 0.
        */

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of number, type 0 when finished.");

        int num = -1;
        while(num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }        

        // Sum of list 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Average of list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        // Max of list
        int max = numbers[0];
        max = numbers.Max(); // using .Max() method

        // foreach loop method
        // foreach (int number in numbers)
        // {
        //     if (number > max)
        //     {
        //         max = number;
        //     }
        // }
        Console.WriteLine($"The max is: {max}");

        /*  NOTES
        LISTS
            - declare List
            - using <> specify data type
            - name the list 
                - List<int> numbers;
                - List<string> words;

            -use 'new' keyword to create a new list. Above only declares.
                List<int> numbers;
                number = new List<int>(); 
                --> usually done on the same line
                List<int> numbers = new List<int>();
                List<string> words = new List<string>();

            ** Need to refer the library at the top of the file. **
                using System.Collections.Generic;
        
        ADDING ITEMS TO LIST --> .Add() method
            List<string> words = new List<string>();
            words.Add("phone");
            words.Add("tablet");

        GET LIST SIZE --> Count property
            Console.WriteLine(words.Count);

        ITERATE THROUGH A LIST --> safest is foreach loop
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            --> but can also loop using index with for loop
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        */
    }

}