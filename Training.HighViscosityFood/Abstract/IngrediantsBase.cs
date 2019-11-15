using System;

namespace Training.HighViscosityFood.Abstract
{
    internal abstract class IngrediantsBase : IFoodProduct
    {
        private IFoodProduct decoratedIngrediant;
        public IngrediantsBase(IFoodProduct decoratedIngrediant)
        {
            this.decoratedIngrediant = decoratedIngrediant;
        }
        internal abstract int GetMyOwnCalories();
        internal abstract int GetMyOwnPrice();
        public int GetCalories()
        {
            return this.decoratedIngrediant.GetCalories() +
                   this.GetMyOwnCalories();
        }
        public int GetPrice()
        {
            return this.decoratedIngrediant.GetPrice() +
                    this.GetMyOwnPrice();
        }
    }
}
