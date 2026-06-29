using System;
using System.Data;

// Abstract classes cannot be instantiated directly
public abstract class Creature
{
    public abstract string Eat();

    public virtual void Poop()
    {
        Console.WriteLine("Pooped");
    }
}

// Derived classes MUST implement every method
public class Human : Creature
{
    // Must use override for abstract methods
    public override string Eat()
    {
        return "ate burger";
    }

    public override void Poop()
    {
        base.Poop();
        Console.WriteLine("without constipation");
    }
}