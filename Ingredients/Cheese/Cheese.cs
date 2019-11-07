using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Cheese
{
    internal class Cheese : IngrediantsBase
    {
        public Cheese(
            IFoodProduct decoratedInstance,
            int weight,
            CheeseType cheeseType) : 
            base(decoratedInstance)
        {

        }
        internal override int GetMyOwnCalories()
        {
            throw new NotImplementedException();
        }

        internal override int GetMyOwnPrice()
        {
            throw new NotImplementedException();
        }

        private int GetCaloriesOfHundredGrammForCheeseType(
            CheeseType typeOfCheese)
        {
            throw new NotImplementedException();
        }

        private int GetPriceForHundredGrammForCheeseType(
            CheeseType typeOfCheese)
        {
            throw new NotImplementedException();
        }
    }
}
