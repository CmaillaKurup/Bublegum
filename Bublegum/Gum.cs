using System;
using System.Collections.Generic;

namespace Bublegum
{
    public class Gum
    {
        private string color;
        private string flavour;
        public Gum(string color, string flavour)
        {
            this.color = color;
            this.flavour = flavour;
        }
        public string Color { get => color; set => color = value; }
        public string Flavour { get => flavour; set => flavour = value; }
        
    }
}