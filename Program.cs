using System;

namespace oo
{

// Base abstract class
public abstract class Vehicle
{
    // Protected members accessible to derived classes
    protected int MaxSpeed { get; set; }
    protected string Model { get; set; }

    // Constructor
    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }

    // Abstract method to be implemented by derived classes
    public abstract void Drive();

    // Virtual method that can be overridden in derived classes
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Model: {Model}");
        Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
    }
}

// Intermediate class inheriting from Vehicle
public class MotorVehicle : Vehicle
{
    public int EngineCapacity { get; set; }

    // Constructor passing parameters to the base constructor
    public MotorVehicle(string model, int maxSpeed, int engineCapacity) 
        : base(model, maxSpeed) 
    {
        EngineCapacity = engineCapacity;
    }

    // Overriding abstract method from base class
    public override void Drive()
    {
        Console.WriteLine($"{Model} with engine capacity {EngineCapacity}cc is driving.");
    }

    // Overriding virtual method to include additional details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}cc");
    }
}

// Derived class inheriting from MotorVehicle
public class Car : MotorVehicle
{
    public int NumberOfDoors { get; set; }

    // Constructor passing parameters to the intermediate class
    public Car(string model, int maxSpeed, int engineCapacity, int numberOfDoors) 
        : base(model, maxSpeed, engineCapacity)
    {
        NumberOfDoors = numberOfDoors;
    }

    // Overriding the Drive method with specific behavior for Car
    public override void Drive()
    {
        Console.WriteLine($"{Model} car with {NumberOfDoors} doors is driving at {MaxSpeed} km/h.");
    }

    // Overriding DisplayInfo to include car-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
}

// Test Program
public class Program
{
    public static void Main()
    {
        Car myCar = new Car("Honda Odyssey", 120, 500, 4);
        myCar.DisplayInfo();    // Display information about the car
        myCar.Drive();          // Call the overridden Drive method
    }
}






}