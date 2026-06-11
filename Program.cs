using System;
using System.Collections.Generic;

public class CsCollections
{
    public static void Main(string[] args)
    {
        // Lists are generic and dynamic arrays unlike arrays they do not need the size to be specified during initializing
        // They are also indexed so you can access each element

        // Declaring
        List<string> names = new List<string>();

        // Adding to the list
        names.Add("Abdo");
        names.Add("Omar");
        names.Add("Joe");

        // Accessing Elements in the list we use two ways
        //1. Foreach loop
        //2. For loop
        Console.WriteLine("Using foreach loop: ");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Using for loop: ");
        // Use the Count attribute that counts the number of items in the list
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        // The last element 
        Console.WriteLine("Last element: " + names[names.Count - 1]);

        //// Removing 
        //// In Removing We have two ways: Remove(), RemoveAt()
        //// Remove() needs the element you want to remove
        //// RemoveAt() needs the index of element you want to remove

        //names.Remove("Omar"); // now the list is ["Abdo", "Joe"]
        //names.RemoveAt(0); // now the list is ["Joe"]

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        // Checking lists
        // We have Contains(), IndexOf()
        // Contains() returns boolean value whether the list contains that item or not, expects you to pass the element you want to check that if it's in the list
        // IndexOf() returns the index of a specified element, expects you pass the element you want to check the index for it

        if(names.Contains("Ahmed")) // the value of the condition is false 
        {
            Console.WriteLine("Hello ahmed!");
        }
        else
        {
            Console.WriteLine("There is no ahmed in list");
        }

        Console.WriteLine("Index of Joe is: " + names.IndexOf("Joe"));
        Console.WriteLine("Index of Alan is: " + names.IndexOf("Alan")); // -1 means not found

        // Built-in functions for sorting lists
        // Sort(), Reverse()
        names.Sort(); // Sorts the list alphapitcally a-z
        names.Reverse(); // Reverse sort the list from z-a
    }
}