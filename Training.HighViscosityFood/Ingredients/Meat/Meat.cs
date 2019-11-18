using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Meat
{
    internal class Meat: WeightedIngrediants
    {
        private MeatType meatType;
        public Meat(
            IFoodProduct decoratedInstance,
            int weight,
            Ingredients.Meat.MeatType meatType) :
            base(decoratedInstance, weight)
        {
            this.meatType = meatType;
        }
        internal override int GetMyOwnCalories()
        {
            return base.GetCaloriesForWeight(this.GetCaloriesOfHundredGrammForMeatOfType(this.meatType));

        }
        internal override int GetMyOwnPrice()
        {
            return base.GetPriceForWeight(this.GetPriceForHundredGrammMeatOfType(this.meatType));

        }
        private int GetCaloriesOfHundredGrammForMeatOfType(
            MeatType typeOfMeat)
        {
            int calories = 0;
            switch (typeOfMeat)
            {
                case MeatType.Pork:
                    calories = 78;
                    break;
                case MeatType.Seafood:
                    calories = 250;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfMeat));
            }
            return calories;
        }
        private int GetPriceForHundredGrammMeatOfType(
            MeatType typeOfMeat)
        {
            int price = 0;
            switch (typeOfMeat)
            {
                case MeatType.Pork:
                    price = 130;
                    break;
                case MeatType.Seafood:
                    price = 230;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfMeat));
            }
            return price;
        }
    }
}
