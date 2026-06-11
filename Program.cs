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


    }
}