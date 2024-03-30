using System;
using System.Collections;
using System.Collections.Generic;

namespace CIT_190_Lesson_7_Collections_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> TOSOfficers = new Dictionary<string, string>();
            TOSOfficers.Add("Captain", "James T. Kirk");
            TOSOfficers.Add("First Officer", "Spock");
            TOSOfficers.Add("Cheif Medical Officer", "Leonard McCoy");
            TOSOfficers.Add("Cheif Engineer", "Montgomery Scott");
            TOSOfficers.Add("Communications Officer", "Nyota Uhura");
            TOSOfficers.Add("Helmsman", "Hikaru Sulu");
            TOSOfficers.Add("Navigator", "Pavel Chekov");

            Console.WriteLine("List of Bridge Positions (keys)");
            Dictionary<string, string>.KeyCollection keys = TOSOfficers.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("List of Senior Officers (values)");
            Dictionary<string, string>.ValueCollection values = TOSOfficers.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();
            Console.WriteLine("Bridge Officer Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in TOSOfficers)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Let's get rid of Chekov, he never did much anyway.");
            TOSOfficers.Remove("Navigator");

            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in TOSOfficers)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("that leaves us with " +  TOSOfficers.Count + " bridge officers.  Sorry, Pavel.");
        }
    }
}
