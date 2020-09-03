using System;

namespace ConsoleApplication1
{
    
    
    public class House
    {

        
        public static string Color { get; set; } = "I am a door, my color is " + Door.DoorColor;
        public static string Area { get; set; } = "I am a house, my area is " + SmallApartment.AreaSize;
    }

    public class SmallApartment : House
    {
        public static string AreaSize { get; set; } = "50";
       
    }

    public class Door : House
    {
        public static string DoorColor { get; set; } = "Brown"; 
    }

    public class Person
    {
        public static string Name { get; set; } = "Michael";
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.Name);
            Console.WriteLine(House.Area);
            Console.WriteLine(House.Color);
        }
    }

    }
    
