using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Base
{
    internal class Base : IFoodProduct
    {
        private const int FIXEDCOSTS = 200;
        public int GetCalories()
        {
            return 0;
        }
        public int GetPrice()
        {
            return FIXEDCOSTS;
        }
    }
}
