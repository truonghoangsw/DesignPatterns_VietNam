using System.Collections.Generic;

namespace Open_Closed_Principle
{
    public class ProductFilter_BeforRefactor
    {
        public IEnumerable<Product> FilterSize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        public IEnumerable<Product> FilterColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var p in products)
                if (p.Color == color && p.Size == size)
                    yield return p;
        }
    }
}