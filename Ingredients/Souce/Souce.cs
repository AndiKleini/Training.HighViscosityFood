using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Souce
{
    internal class Souce: IngrediantsBase
    {
        public Souce(
            IFoodProduct decoratedInstance,
            Ingredients.Souce.SouceType souceType) :
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

        private int GetCaloriesOfHundredGrammForSouceType(
            SouceType typeOfSouce)
        {
            throw new NotImplementedException();
        }

        private int GetPriceForHundredGrammForSouceType(
            SouceType typeOfSouce)
        {
            throw new NotImplementedException();
        }
    }
}
