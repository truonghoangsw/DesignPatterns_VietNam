﻿using System;
using System.Reflection.Metadata.Ecma335;
using Interface_Segregation_Principle;

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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

