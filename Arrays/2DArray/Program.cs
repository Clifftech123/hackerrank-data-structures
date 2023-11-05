using System;
using System.Collections.Generic;
using System.Linq;

class Program {

    // This function takes a string as input, reverses the order of the characters, and returns the reversed string.
    public static string reverseNumber(string a){
        char[] arr = a.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    // The main function of the program.
    static void Main(string[] args)
    {
        // Prompt the user to enter a number.
        Console.WriteLine("Enter a number:");
        string num = Console.ReadLine().Trim();

        // Call the reverseNumber function to reverse the order of the digits.
        string res = reverseNumber(num);

        // Print the reversed number to the console.
        Console.WriteLine("Reversed Number: " + res);
    }
}