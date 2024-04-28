using System;
using Task6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter index: ");
        string index = Console.ReadLine();
        
        Console.WriteLine("Enter country: ");
        string country = Console.ReadLine();
        
        Console.WriteLine("Enter city: ");
        string city = Console.ReadLine();
        
        Console.WriteLine("Enter street: ");
        string street = Console.ReadLine();
        
        Console.WriteLine("Enter house: ");
        string house = Console.ReadLine();
        
        Console.WriteLine("Enter appartment: ");
        string appartment = Console.ReadLine();
            
        Address address = new Address(index, country, city, street, house, appartment); 
        address.ShowAdress();
    }
}