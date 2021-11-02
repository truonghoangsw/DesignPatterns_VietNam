using System;
using System.Collections.Generic;
using System.IO;

namespace Single_Responsibility_Principle
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        private void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

    }
    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName,bool overwirte = false)
        {
            if(overwirte || !File.Exists(fileName))
                File.WriteAllText(fileName, j.ToString());
        }
    }
}