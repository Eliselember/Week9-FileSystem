﻿using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishes = new List<string>();
            myWishes.Add("new crocs");
            myWishes.Add("new umbrella");
            myWishes.Add("new coffee mug");
            myWishes.Add("new phone");

            //Console.WriteLine($"There are {myWishes.Count} items on your wishlist.");

            //Console.WriteLine(myWishes[0]);
            //Console.WriteLine(myWishes[myWishes.Count - 1]);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"Item on your wishlist: {wish}");
            }

            Console.WriteLine();

            Console.WriteLine("Enter a wish:");
            string userWish = Console.ReadLine();

            myWishes.Add(userWish);


            
        }
            

    }  
    
}
