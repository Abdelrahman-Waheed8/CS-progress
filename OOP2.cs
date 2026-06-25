using System;

// This is mainly focused on Inheritance
public class Animal
{
    public string Species {get; set;}
    public Animal(string species) {Species = species;}

// This 'virtual' keyword is actually as an interface for the function and you can override it from the child classes
    public virtual string makeSound()
    {
        return "Sound: ";
    }
}

public class Dog : Animal
{
    public int legs {get; set;}

// base keyword is for passing arguments to the parent constructor so species is passed to the Animal constructor
    public Dog(string species, int legs) : base(species) 
    {
        this.legs = legs;
    }

// 'override' overriding the code in the parent class obviously it has to be the same name
    public override string makeSound()
    {
        return base.makeSound() + "Hoof!";
    }
}