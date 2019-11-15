using Training.HighViscosityFood.Ingredients.Base;

namespace Training.HighViscosityFood
{
    public class BurgerBuilder
    {
        public Burger GetClassicBurger()
        {
            return new Base().
                AddCheese(Ingredients.Cheese.CheeseType.Tilsitter).
                OfWeight(200).
                AddHam(Ingredients.Ham.HamType.Pancetta).
                OfWeight(300).
                AddSouce(Ingredients.Souce.SouceType.Hollandeise).
                ToBurger();
        }
    }
}
