using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Souce
{
    internal class Souce: IngrediantsBase
    {
        private SouceType souceType;
        public Souce(
            IFoodProduct decoratedInstance,
            Ingredients.Souce.SouceType souceType) :
            base(decoratedInstance)
        {
            this.souceType = souceType;
        }
        internal override int GetMyOwnCalories()
        {
            return this.GetCaloriesForSouceOfType(this.souceType);
        }
        internal override int GetMyOwnPrice()
        {
            return this.GetPriceForSouceType(this.souceType);
        }
        private int GetCaloriesForSouceOfType(
            SouceType typeOfSouce)
        {
            int calories = 0;
            switch (typeOfSouce)
            {
                case SouceType.Tartar:
                    calories = 110;
                    break;
                case SouceType.Hollandeise:
                    calories = 250;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfSouce));
            }
            return calories;
        }
        private int GetPriceForSouceType(
            SouceType typeOfSouce)
        {
            int price = 0;
            switch (typeOfSouce)
            {
                case SouceType.Tartar:
                    price = 200;
                    break;
                case SouceType.Hollandeise:
                    price = 300;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOfSouce));
            }
            return price;
        }
    }
}
