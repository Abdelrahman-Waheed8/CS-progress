using System;
using System.Collections.Generic;

public class Dict
{
	public Dict()
	{
	}

	public void DictionaryUse()
	{
		// Now Dictionaries are a new thing which basically store a key and a value (pairs) each key maps to one value. (Key must be Unique!)
		// Look up in dictionaries basically have time complexity of O(1) since it looks for the value by specific key since it's unique 
		// Unlike lists which takes O(n)

		// Declaring empty dictionary
		Dictionary<string, int> scores = new Dictionary<string, int>();

		//// Declaring dictionary with initial values 
		//Dictionary<string, int> scores = new Dictionary<string, int>
		//{
		//	{"Abdo", 19 },
		//	{"Booody", 29}
		//};

		//// Another way of Declaring dictionary with initial values
		//Dictionary<string, int> scores = new Dictionary<string, int>
		//{
		//	["Abdo"] = 0,
		//	["Jojo"] = 1
		//};

		// Adding items in dictionary Add() accepts pair of data (key, value)
		scores.Add("Abdo", 50);
        scores.Add("Jane", 60);
        scores.Add("Zane", 70);
		// scores.Add("Abdo", 100); // This Throws an Exception as key "Abdo" already exists

		// Accessing Values using indexer []
		// Basically you type the key in the indexer and it return the value
		int AbdoScore = scores["Abdo"]; // 50
		Console.WriteLine("Abdo score: " + AbdoScore);
		//int kikoscore = scores["kiko"]; // Throws an Exception also as it's not found

		//Indexers also can add to the dictionary and updates if existing key is passed
		scores["Omar"] = 80;
		scores["Zane"] = 95;

		// Checking for items in Dictionary
		// Like the lists there is ContainsKey() function that accept the key and returns a boolean value whether it's found or not 
		bool hasAhmed = scores.ContainsKey("Ahmed"); // hasAhmed = false


		// TryGetValue() returns true if value found and false if not
		if(scores.TryGetValue("Abdo", out int Scr))
		{
			Console.WriteLine($"Abdo score is {Scr}"); // 50
		}

		if(scores.TryGetValue("Jamal", out int Scr2)) // key not found then value is 0 (default)
		{
			Console.WriteLine($"Jamal score is {Scr2}"); // This won't execute as the condition is false
		}

		// Looping through dictionaries we use for loops
		foreach(var pair in scores)
		{
			Console.WriteLine($"{pair.Key} score is {pair.Value}");
		}

		// Another way

		foreach(var (key,value) in scores)
		{
            Console.WriteLine($"{key} score is {value}");
        }
    }
}
