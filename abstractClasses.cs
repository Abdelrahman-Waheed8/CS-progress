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

public class Human : Creature
{
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