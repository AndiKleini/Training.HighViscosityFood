using System;

namespace Training.HighViscosityFood.Abstract
{
    internal abstract class WeightedIngrediants : IngrediantsBase
    {
        private int weight;
        public WeightedIngrediants(IFoodProduct foodProduct, int weight) : base(foodProduct) 
        {
            this.weight = weight;
        }
        protected int GetPriceForWeight(int pricePerHundredGramm)
        {
            return pricePerHundredGramm * this.weight / 100;
        }
        protected int GetCaloriesForWeight(int caloriesPerHundredGramm)
        {
            return caloriesPerHundredGramm * this.weight / 100;
        }
    }
}
