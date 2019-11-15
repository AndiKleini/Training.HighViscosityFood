using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Ingredients.Cheese
{
    public class CheesePhrase
    {
        private IFoodProduct currentFood;
        private CheeseType Cheese;
        public CheesePhrase(
            IFoodProduct currentFood,
            CheeseType Cheese)
        {
            this.currentFood = currentFood;
            this.Cheese = Cheese;
        }
        public IFoodProduct OfWeight(int weight)
        {
            return new Cheese(
                this.currentFood,
                weight, this.Cheese);
        }
    }
}
