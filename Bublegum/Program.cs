using System;
using System.Collections.Generic;

namespace Bublegum
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<12; i++) 
            {
                GumInDisp.Add(new Gum("Red", "Strawberry"));
                GumInDisp.Add(new Gum("Blue", "Mint"));
                GumInDisp.Add(new Gum("Green", "Watermelon"));
                GumInDisp.Add(new Gum("Yellow", "Lemon"));
            }
            
            List<string> gum = new List<string>();
            gum.Add("red");
            gum.Add("green");
            gum.Add("blue");
            gum.Add("yellow");
            gum.Add("purple");
            gum.Add("orange");


        }
    }
}