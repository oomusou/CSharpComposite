namespace ShoppingCartLibrary
{
    public class IPadAir : IPrice
    {
        private const double Price = 10000.0;

        public double GetPrice()
        {
            return Price;
        }
    }
}