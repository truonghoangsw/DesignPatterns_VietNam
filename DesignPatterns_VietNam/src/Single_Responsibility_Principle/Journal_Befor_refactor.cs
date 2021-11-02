using System;
using System.Collections.Generic;
using System.IO;

namespace Single_Responsibility_Principle
{
    public class Journal_Befor_refactor
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

        #region mistake Single_Responsibility_Principle
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }
        private static Journal_Befor_refactor Load(string fileName)
        {
            return null;
        }
        public void Load(Uri uri)
        {

            throw new NotImplementedException();
        }
        #endregion

    }
}