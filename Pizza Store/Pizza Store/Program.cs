// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using Pizza_Store;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a pizza type to order: ");
        var type = Console.ReadLine();
        var pizzaStore = new PizzaStore();
        
        pizzaStore.OrderPizza(type);
        
        
    }
}