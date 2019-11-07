using Training.HighViscosityFood.Ingredients.Base;

namespace Training.HighViscosityFood
{
    public class BurgerBuilder
    {
        public Burger GetMyBurger()
        {
            return new Base().
                AddCheese(Ingredients.Cheese.CheeseType.Tilsitter).
                OfWeight(200).
                AddHam(Ingredients.Ham.HamType.Pancetta).
                OfWeight(300).
                ToBurger();
        }
    }
}
