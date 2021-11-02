using System;
using System.Diagnostics;

namespace Single_Responsibility_Principle
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I work");
            j.AddEntry("I fix a bug");

            var p = new Persistence();
            string fileName = @"C:\temp\journal.txt";
            p.SaveToFile(j,fileName,true);
        }
    }
}