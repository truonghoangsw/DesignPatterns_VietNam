using System;

namespace Interface_Segregation_Principle
{
    public class Document
    {
    }

    public interface IMachine
    {
        public void Fax(Document d);

        public void Scan(Document d);

        public void Print(Document d);
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}