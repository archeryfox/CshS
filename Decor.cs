using System;
namespace Cakes
{
    public class Decor
    {
        public Decor() { }

        public Decor(int amount, string view, string color)
        {
            this.Amount = amount;
            this.View = view;
            this.Color = color;
        }
        readonly public int Amount = 0;
        readonly public string View = "";
        readonly public string Color = "";

    }
}

