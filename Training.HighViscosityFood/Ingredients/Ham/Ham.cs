using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Ham
{
    internal class Ham : IngrediantsBase
    {
        private HamType hamType;
        private int weight;
        public Ham(
            IFoodProduct decoratedInstance,
            int weight,
            HamType hamType) :
            base(decoratedInstance)
        {
            this.hamType = hamType;
            this.weight = weight;
        }
        internal override int GetMyOwnCalories()
        {
            return (this.weight * this.GetCaloriesOfHundredGrammForHamType(this.hamType)) / 100;

        }
        internal override int GetMyOwnPrice()
        {
            return (this.weight * this.GetPriceForHundredGrammHamType(this.hamType)) / 100;

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
