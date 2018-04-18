using System.Collections.Generic;

namespace ShoppingCartLibrary
{
    public class ShoppingCartService
    {
        private readonly List<IPrice> _carts = new List<IPrice>();

        public void AddCart(IPrice product)
        {
            _carts.Add(product);
        }

        public double CalculatePrice()
        {
            var sum = 0.0;

            foreach (var product in _carts)
            {
                sum += product.GetPrice();
            }

            return sum;
        }
    }
}