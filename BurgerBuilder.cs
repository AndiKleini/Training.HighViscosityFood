using Training.HighViscosityFood.Ingredients.Base;

namespace Training.HighViscosityFood
{
    public class BurgerBuilder
    {
        private const int WRAPPING_COSTS = 20;
        public Burger GetMyBurger(bool isWrapped = false)
        {
            var tmpBurger = new Base().
                AddCheese(Ingredients.Cheese.CheeseType.Tilsitter).
                OfWeight(200).
                AddHam(Ingredients.Ham.HamType.Pancetta).
                OfWeight(300).
                AddSouce(Ingredients.Souce.SouceType.Hollandeise);
            if (isWrapped)
            {
                tmpBurger = tmpBurger.AddOther(WRAPPING_COSTS, 0, "Wrapping");
            }
            return tmpBurger.ToBurger();
        }
    }
}
