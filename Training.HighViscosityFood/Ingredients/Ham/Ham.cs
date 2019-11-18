using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Ham
{
    internal class Ham : WeightedIngrediants
    {
        private HamType hamType;
        public Ham(
            IFoodProduct decoratedInstance,
            int weight,
            HamType hamType) :
            base(decoratedInstance, weight)
        {
            this.hamType = hamType;
        }
        internal override int GetMyOwnCalories()
        {
            return base.GetCaloriesForWeight(this.GetCaloriesOfHundredGrammForHamType(this.hamType));

        }
        internal override int GetMyOwnPrice()
        {
            return base.GetPriceForWeight(this.GetPriceForHundredGrammHamType(this.hamType));

        }
        private int GetCaloriesOfHundredGrammForHamType(
            HamType typeOfHam)
        {
            int calories = 0;
            switch (typeOfHam)
            {
                case HamType.Pancetta:
                    calories = 120;
                    break;
                case HamType.BlackForest:
                    calories = 143;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfHam));
            }
            return calories;
        }

        private int GetPriceForHundredGrammHamType(
            HamType typeOfHam)
        {
            int price = 0;
            switch (typeOfHam)
            {
                case HamType.Pancetta:
                    price = 170;
                    break;
                case HamType.BlackForest:
                    price = 195;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfHam));
            }
            return price;
        }
    }
}
