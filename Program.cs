using System;
using System.Collections.Generic;

namespace lists
{
    public class Program
    {
        public static void Main()
        {
            List<string> planetList = new List<string>() {
                "Mercury",
                "Mars"
                };

            planetList.ForEach(planets => Console.WriteLine(planets));

            planetList.Add("Jupiter");
            Console.WriteLine("List of planets after adding Jupiter:");
            planetList.ForEach(planets => Console.WriteLine(planets));

            planetList.Add("Saturn");
            Console.WriteLine("List of planets after adding Saturn:");
            planetList.ForEach(planets => Console.WriteLine(planets));

            List<string> newPlanets = new List<string>(){
                "Uranus",
                "Neptune"
            };

            planetList.InsertRange(4, newPlanets);
            Console.WriteLine("List of planets after adding two more:");
            planetList.ForEach(planets => Console.WriteLine(planets));

            planetList.Insert(2, "Venus");
            Console.WriteLine("List of planets after adding Venus where it belongs:");
            planetList.ForEach(planets => Console.WriteLine(planets));

            planetList.Insert(3, "Earth");
            Console.WriteLine("List of planets after adding Earth where it lives:");
            planetList.ForEach(planets => Console.WriteLine(planets));

            planetList.Add("Baby Pluto");
            Console.WriteLine("List of planets after adding BB Pluto:");
            planetList.ForEach(planets => Console.WriteLine(planets));


        }
    }
}