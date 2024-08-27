using System;

namespace ConsoleUI;

public class Motorcycle:Vehicle
{
    public bool HasSideCart { get; set; }


    public override void DriveAbstract()
    {
        Console.WriteLine($"The {Make} {Model} is now driving");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine($"The {Make} {Model} is now cruising along the highway!");
    }
}