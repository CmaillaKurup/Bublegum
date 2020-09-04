namespace Bublegum
{
    public class Gum
    {
        //declaring variabals
        private string color;
        private string flavour;
        
        //Constructor
        public Gum(string color, string flavour)
        {
            this.color = color;
            this.flavour = flavour;
        }
        
        //Get/set methoeds
        public string Color { get => color; set => color = value; }
        public string Flavour { get => flavour; set => flavour = value; }
        
    }
}