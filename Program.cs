using System;
using System.Collections.Generic;

namespace Planets_and_probes_and_keyvaluePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Neptune", "Uranus", "Pluto" };


            var probeDestinations = new List<KeyValuePair<string, string>>();
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Mercury"));
            probeDestinations.Add(new KeyValuePair<string, string>("Sputnik 19", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Zond 2", "Mars"));

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                var matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> destination in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                    if (destination.Value == planet){
                        matchingProbes.Add(destination.Key);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(",", matchingProbes)}");
            }
        }
    }
}
