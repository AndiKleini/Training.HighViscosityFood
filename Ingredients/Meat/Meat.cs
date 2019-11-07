using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Meat
{
    internal class Meat: IngrediantsBase
    {
        public Meat(
            IFoodProduct decoratedInstance,
            int weight,
            Ingredients.Meat.MeatType hamType) :
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

        private int GetCaloriesOfHundredGrammForMeatType(
            MeatType typeOfMeat)
        {
            throw new NotImplementedException();
        }

        private int GetPriceForHundredGrammForMeatType(
            MeatType typeOfMeat)
        {
            throw new NotImplementedException();
        }
    }
}
