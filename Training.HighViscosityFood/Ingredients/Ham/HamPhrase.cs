using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Ham
{
    public class HamPhrase
    {
        private IFoodProduct currentFood;
        private HamType Ham;
        public HamPhrase(
            IFoodProduct currentFood,
            HamType Ham)
        {
            this.currentFood = currentFood;
            this.Ham = Ham;
        }
        public IFoodProduct OfWeight(int weight)
        {
            return new Ham(
                this.currentFood,
                weight, this.Ham);
        }
    }
}
