using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // All of the code in this file is from the tutorial at https://www.youtube.com/watch?v=2VtJdXbX4xY
            // All the code below describes what you can do with strings
            string randString = "This is a string";
            Console.WriteLine("String Length : {0}", randString.Length); // This shows the length of the string
            Console.WriteLine("String Contains is: {0}", randString.Contains("is")); // This shows if the string contains the word "is"
            Console.WriteLine("Index of is: {0}", randString.IndexOf("is")); // This shows the index of the word "is"
            Console.WriteLine("Remove String: {0}", randString.Remove(10,6)); // This removes the string from the index 10 to 6
            Console.WriteLine("Insert String: {0}", randString.Insert(10, "short")); // This inserts the string at the index 10
            Console.WriteLine("Replace String: {0}", randString.Replace("string", "sentence")); // This replaces the word "string" with "sentence"
            Console.WriteLine("Compare A to B: {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase)); // This compares the two strings
            
            Console.WriteLine("-----------------------------");
            Console.WriteLine("A = a: {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase)); // This compares the two strings and returns true if they are equal
            Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.')); // This pads the string with the character "." to the left
            Console.WriteLine("Pad Right : {0}", randString.PadRight(20, '.')); // This pads the string with the character "." to the right
            Console.WriteLine("Trim : {0}", randString.Trim()); // This trims the string
            Console.WriteLine("Uppercase : {0}", randString.ToUpper()); // This converts the string to uppercase
            Console.WriteLine("Lowercase : {0}", randString.ToLower()); // This converts the string to lowercase
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul","rabbit", "eating", "field"); // This formats the string
            // Explain line 25 above
            Console.WriteLine(newString + "\n");
            // Escape characters are \n for newline, \t for tab, \' for single quote, \" for double quote, \\ for backslash
            Console.WriteLine(@"Exactly What I Typed \n"); // Verbatim string literal

        }
    }
}