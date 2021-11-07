namespace Open_Closed_Principle
{
    public class ColorSpectification : ISpecification<Product>
    {
        public ColorSpectification(Color color)
        {
            this.color = color;
        }
        
        private Color color { get; set; }
        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }
}