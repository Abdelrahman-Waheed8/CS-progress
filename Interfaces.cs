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

public interface IMovable
{
    void Move(int distance);
    int TotalDistance { get; }
}

public interface ISoundMaker
{
    string MakeSound();
}

public class Car : IMovable
{
    public int TotalDistance {get; private set;}

    public void Move(int distance)
    {
        TotalDistance += distance;
    }
}
public class Robot : IMovable
{
    public int TotalDistance {get; private set;}

    public void Move(int distance)
    {
        TotalDistance += distance;
    }
}
public class Ship : IMovable
{
    public int TotalDistance {get; private set;}

    public void Move(int distance)
    {
        TotalDistance += distance;
    }
}

// // Polymorphism
// void Moveall(IMovable[] movable, int distance)
// {
//     foreach(var m in movable)
//     {
//         m.Move(distance);
//     }
// }

// // Treating classes implementing same interface as a group (as if the interface IMovable is a data type)
// IMovable[] fleet = {new Car(), new Robot(), new Ship()};
// Moveall(fleet, 10);

// Multiple Interfaces
// while c# doesn't support multiple class inheritance it can implement multiple interfaces making it capable of doing alot
// classes implementing two interfaces must implement everything from the two interfaces ... and so on

// Must take in considertion the Interface Segregation principle from the SOLID principles where it states that a classs
// should never implement an interface it doesn't use

// Implemented the two interfaces declared above
public class SpaceShip: IMovable, ISoundMaker
{
    public int TotalDistance {get; private set;}

    public void Move(int distance)
    {
        TotalDistance += distance;
    }

    public string MakeSound()
    {
        return "Beep boop!";
    }
}