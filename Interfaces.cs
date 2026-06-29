using System;
using System.ComponentModel;

// It defines a contract on how classes should behave but not how it is done (as rules they must follow)
public interface ICreature
{
    string Move();
}   

public interface IObject
{
    string Make();
    string Destroy();
    int weight {get; set;}
}

public class HumanBeing : ICreature
{
    public string Move()
    {
        return "Moved with two legs";
    }
}

public class Cup : IObject
{
    public int weight {get; set;}
    public string Make()
    {
        return "Made a glass cup";
    }

    public string Destroy()
    {
        return "destroyed a cup";
    }
}