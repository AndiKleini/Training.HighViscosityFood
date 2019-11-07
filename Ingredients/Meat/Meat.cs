using System;
using System.Collections.Generic;
using System.Text;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Meat
{
    internal class Meat: IngrediantsBase
    {
        private int weight;
        private MeatType meatType;
        public Meat(
            IFoodProduct decoratedInstance,
            int weight,
            Ingredients.Meat.MeatType meatType) :
            base(decoratedInstance)
        {
            this.weight = weight;
            this.meatType = meatType;
        }
        internal override int GetMyOwnCalories()
        {
            return (this.weight * this.GetCaloriesOfHundredGrammForMeatOfType(this.meatType)) / 100;

        }
        internal override int GetMyOwnPrice()
        {
            return (this.weight * this.GetPriceForHundredGrammMeatOfType(this.meatType)) / 100;

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
                    price = 78;
                    break;
                case MeatType.Seafood:
                    price = 250;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfMeat));
            }
            return price;
        }
    }
}
