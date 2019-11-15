using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Cheese
{
    internal class Cheese : IngrediantsBase
    {
        private int weight;
        private CheeseType cheeseType;
        public Cheese(
            IFoodProduct decoratedInstance,
            int weight,
            CheeseType cheeseType) : 
            base(decoratedInstance)
        {
            this.cheeseType = cheeseType;
            this.weight = weight;
        }
        internal override int GetMyOwnCalories()
        {
            return (this.weight * this.GetCaloriesOfHundredGrammForCheeseType(this.cheeseType)) / 100;
        }
        internal override int GetMyOwnPrice()
        {
            return (this.weight * this.GetPriceForHundredGrammForCheeseType(this.cheeseType)) / 100;
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
