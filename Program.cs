using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(15, "Zey");
            myDictionary.Add(2, "Ali");

            for (int i = 0; i < myDictionary.Count(); i++)
            {
                Console.WriteLine(myDictionary.forKeys[i] + " " + myDictionary.forVal[i]);
            }
          
        }
    }
}
