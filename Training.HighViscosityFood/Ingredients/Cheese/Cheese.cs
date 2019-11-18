using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Cheese
{
    internal class Cheese : WeightedIngrediants
    {
        private CheeseType cheeseType;
        private int weight;
        public Cheese(
            IFoodProduct decoratedInstance,
            int weight,
            CheeseType cheeseType) : 
            base(decoratedInstance, weight)
        {
            this.cheeseType = cheeseType;
            this.weight = weight;
        }
        internal override int GetMyOwnCalories()
        {
            return base.GetCaloriesForWeight(this.GetCaloriesOfHundredGrammForCheeseType(this.cheeseType));
        }
        internal override int GetMyOwnPrice()
        {
            return base.GetPriceForWeight(this.GetPriceForHundredGrammForCheeseType(this.cheeseType));
        }
        private int GetCaloriesOfHundredGrammForCheeseType(
            CheeseType typeOfCheese)
        {
            int calories = 0;
            switch (typeOfCheese)
            {
                case CheeseType.Tilsitter:
                    calories = 70;
                    break;
                case CheeseType.CottageCheese:
                    calories = 87;
                    break;
                case CheeseType.Edamer:
                    calories = 110;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfCheese));
            }
            return calories;
        }
        private int GetPriceForHundredGrammForCheeseType(
            CheeseType typeOfCheese)
        {
            int price = 0;
            switch (typeOfCheese)
            {
                case CheeseType.Tilsitter:
                    price = 50;
                    break;
                case CheeseType.CottageCheese:
                    price = 10;
                    break;
                case CheeseType.Edamer:
                    price = 60;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfCheese));
            }
            return price;
        }
    }
}
