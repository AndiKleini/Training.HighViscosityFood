using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Other
{
    internal class Other : IngrediantsBase
    {
        private int price;
        private int calories;
        private string name;
        public Other(
            IFoodProduct decoratedInstance,
            int price,
            int calories,
            string name) :
            base(decoratedInstance)
        {
            this.price = price;
            this.calories = calories;
            this.name = name;
        }
        internal override int GetMyOwnCalories()
        {
            return this.calories;
        }
        internal override int GetMyOwnPrice()
        {
            return this.price;
        }
    }
}
