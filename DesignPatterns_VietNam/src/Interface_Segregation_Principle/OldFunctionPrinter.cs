using System;

namespace Interface_Segregation_Principle
{
    public class OldFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            // Only support?
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }
    }
}