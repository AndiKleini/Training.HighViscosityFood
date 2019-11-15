using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood
{
    public class Burger 
    {
        private IFoodProduct underlyingFoodProduct;
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
                Price = this.underlyingFoodProduct.GetPrice()
            };
        }
    }
}
