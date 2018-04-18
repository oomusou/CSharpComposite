using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartLibrary
{
    public class AppleCombo : IPrice
    {
        private const double Discount = 0.9;
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
            return Discount * _products.Sum(product => product.GetPrice());
        }
    }
}