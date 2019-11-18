using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood
{
    public class Burger 
    {
        private const int WRAPPING_PRICE = 20;
        private IFoodProduct underlyingFoodProduct;
        public bool IsWrapped { get; set; }
        private Func<DateTime> getTimeStamp = () => DateTime.Now;
        public Burger(IFoodProduct underlyingFoodProduct)
        {
            this.underlyingFoodProduct = underlyingFoodProduct;
        }
        public Burger(IFoodProduct underlyingFoodProduct, Func<DateTime> getTimeStamp = null) :
            this(underlyingFoodProduct)
        {
            if (getTimeStamp != null)
            {
                this.getTimeStamp = getTimeStamp;
            }
        }
        public Bill ToBill()
        {
            return new Bill()
            {
                Calories = this.underlyingFoodProduct.GetCalories(),
                OrderedAt = this.getTimeStamp(),
                Price = this.underlyingFoodProduct.GetPrice() + 
                        (this.IsWrapped ? WRAPPING_PRICE : 0)
            };
        }
    }
}
