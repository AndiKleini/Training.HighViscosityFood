using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Meat
{
    public class MeatPhrase
    {
        private IFoodProduct currentFood;
        private MeatType meat;
        public MeatPhrase(
            IFoodProduct currentFood,
            MeatType meat)
        {
            this.currentFood = currentFood;
            this.meat = meat;
        }
        public IFoodProduct OfWeight(int weight)
        {
            return new Meat(
                this.currentFood,
                weight, this.meat);
        } 
    }
}
