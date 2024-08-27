using System;

namespace ConsoleUI;

public class Car:Vehicle
{
    public bool HasTrunk { get; set; }


    public override void DriveAbstract()
    {
        Console.WriteLine($"The {Make} {Model} is now driving");
    }
}