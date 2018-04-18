using System.Collections.Generic;

namespace ShoppingCartLibrary
{
    public class AppleCombo : IPrice
    {
        private readonly List<IPrice> _products;

        public AppleCombo()
        {
            _products = new List<IPrice>
            {
                new MacBookPro(),
                new IPadAir(),
                new AppleWatch()
            };
        }
        
        public double GetPrice()
        {
            var sum = 0.0;

            foreach (var product in _products)
            {
                sum += product.GetPrice();
            }

            return 0.9 * sum;
        }
    }
}