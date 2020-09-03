using System;
using System.Collections.Generic;

namespace Bublegum
{
    public class Dispencer
    {
        public static List<Gum> gums = new List<Gum>();


        public void AddGum()
        {
            for (int i = 0; i < 55; i++)
            {
                Random rand = new Random();
                switch (rand.Next(1, 5))
                {
                    case 1:
                        gums.Add(new Gum("Red", "Strawberry"));
                        break;
                    case 2:
                        gums.Add(new Gum("Blue", "Mint"));
                        break;
                    case 3:
                        gums.Add(new Gum("Green", "Watermelon"));
                        break;
                    case 4:
                        gums.Add(new Gum("Yellow", "Lemon"));
                        break;
                    default:
                        break;
                }
            }
        }

        public List<Gum> GetGums()
        {
            //Skal bare returnere min liste der hedder gums
            return gums;
        }
        
    }
}