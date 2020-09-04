using System;
using System.Collections.Generic;

namespace Bublegum
{
    public class Dispencer
    {
        //Creating an new list
        public static List<Gum> gums = new List<Gum>();
        
        //rand is used in both AddGum and CoinInput.
        //Makes sure that AddGum fill up the dispenser with randome gums.
        //Makes sure that you get an randome gum when you trow in a coin.
        Random rand = new Random();
        
        //This methode are used to add gums in to the dispencer
        public void AddGum()
        {
            for (int i = 0; i < 4; i++)
            {
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

        //This method ar only used for returning the gums
        public List<Gum> GetGums()
        {
            return gums;
        }

        //in this method you are asked to throw in af coin and it has to be an 5'er.
        //if not a 5 you will be asked to throw a new.
        //as soon you throw a 5'er you will get a gum and that gum will be removed fro the list of gumms
        public void CoinInput(int throwCoin)
        {
            while (throwCoin != 5)
            {
                if (throwCoin > 5)
                {
                    Console.WriteLine("to big");
                }
                if (throwCoin < 5)
                {
                    Console.WriteLine("to small");
                }

                throwCoin = int.Parse(Console.ReadLine());
            }

            if (throwCoin == 5) 
            {
                int randGum = rand.Next(gums.Count);
                
                Console.WriteLine("Color: " + gums[randGum].Color + "Flavour: " + gums[randGum].Flavour);
                gums.Remove(gums[randGum]);
            }
        }
    }
}