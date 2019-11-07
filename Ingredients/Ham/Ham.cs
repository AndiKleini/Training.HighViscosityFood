using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Ham
{
    internal class Ham : IngrediantsBase
    {
        public Ham(
            IFoodProduct decoratedInstance,
            int weight,
            HamType HamType) :
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

        private int GetCaloriesOfHundredGrammForHamType(
            HamType typeOfHam)
        {
            throw new NotImplementedException();
        }

        private int GetPriceForHundredGrammForHamType(
            HamType typeOfHam)
        {
            throw new NotImplementedException();
        }
    }
}
