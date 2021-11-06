using System;

namespace Open_Closed_Principle
{
    public enum Color
    {
        Red, Green, Bule
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Product
    {
        public Product(Size size, Color color, string name)
        {
            Size = size;
            Color = color;
            Name = name;
        }

        public Size Size { get; set; }
        public Color Color { get; set; }
        public string Name { get; set; }
    }


    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}