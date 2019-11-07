using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood
{
    public class Burger : IFoodProduct
    {
        public int GetPrice()
        {
            throw new NotImplementedException();
        }

        public int GetCalories()
        {
            throw new NotImplementedException();
        }

        public DateTime OrderDate { get; set; }
    }
}
