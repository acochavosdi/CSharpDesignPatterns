using System;
using static CSharpDesignPatterns.SOLID.OpenClosedPrinciple.Enums;


namespace CSharpDesignPatterns.SOLID.OpenClosedPrinciple
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;
            Color = color;
            Size = size;
        }

        public override string ToString()
        {
            return $"Product: {this.Name}; Color:{this.Color}; Size: {this.Size}";
        }
    }
}
