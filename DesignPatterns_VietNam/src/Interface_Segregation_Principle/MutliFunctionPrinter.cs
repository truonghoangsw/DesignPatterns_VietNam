using System;

namespace Interface_Segregation_Principle
{
    public interface IPrinter
    {
        void Print(Document T);
    }

    public interface IScanner
    {
        void Scan(Document t);
    }

    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document t)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document t)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IMultiFunctionMachine : IScanner, IPrinter
    {
    }

    public class MultiFunctionMachine : IMultiFunctionMachine
    {
        public IScanner Scanner { get; set; }
        public IPrinter Printer { get; set; }

        public MultiFunctionMachine(IScanner scanner = null, IPrinter printer = null)
        {
            Scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
            Printer = printer ?? throw new ArgumentNullException(nameof(printer));
        }

        public void Scan(Document t)
        {
            Scanner.Scan(t);
        }

        public void Print(Document t)
        {
            Printer.Print(t);
        }
    }

    public class MutliFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            //
        }
    }
}