using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Tests.Abstract
{
    internal class WeightedIngrediantsTestExposal : WeightedIngrediants
    {
        public WeightedIngrediantsTestExposal(
            IFoodProduct foodProduct, 
            int weight) : 
            base(foodProduct, weight) {}
        internal override int GetMyOwnCalories()
        {
            throw new NotImplementedException();
        }
        internal override int GetMyOwnPrice()
        {
            throw new System.NotImplementedException();
        }
        internal int GetPriceForWeightTestExposal(int pricePerHundredGramm)
        {
            return this.GetPriceForWeight(pricePerHundredGramm);
        }
        internal int GetCaloriesForWeightTestExposal(int caloriesPerHundredGramm)
        {
            return this.GetCaloriesForWeight(caloriesPerHundredGramm);
        }
    }
}
