using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Tests.Abstract
{
    internal class IngrediantsBaseTestExposal : IngrediantsBase
    {
        private int ownCalories;
        private int ownPrice;
        public IngrediantsBaseTestExposal(
            IFoodProduct decoratedIngrediant,
            int ownCalories,
            int ownPrice) : 
            base(decoratedIngrediant)
        {
            this.ownCalories = ownCalories;
            this.ownPrice = ownPrice;
        }
        internal override int GetMyOwnCalories()
        {
            return this.ownCalories;
        }
        internal override int GetMyOwnPrice()
        {
            return this.ownPrice;
        }
    }
}
