using System;
namespace Tortics
{
    public class Decor
    {
        public Decor() { }

        public Decor(int amount, string view, string color, int size)
        {
            this.Amount = amount;
            this.View = view;
            this.Color = color;
            this.Size = size;
        }
        readonly public int Amount = 0;
        readonly public string View = "";
        readonly public string Color = "";
        readonly public int Size = 1;

    }
}

