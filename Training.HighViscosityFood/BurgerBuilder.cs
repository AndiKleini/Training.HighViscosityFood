using Training.HighViscosityFood.Ingredients.Base;

namespace Training.HighViscosityFood
{
    public class BurgerBuilder
    {
        public Burger GetClassicBurger(bool isWrapped = false)
        {
            var foodProduct = new Base().
                AddCheese(Ingredients.Cheese.CheeseType.Tilsitter).
                OfWeight(200).
                AddHam(Ingredients.Ham.HamType.Pancetta).
                OfWeight(300).
                AddSouce(Ingredients.Souce.SouceType.Hollandeise);
            if (isWrapped)
            {
                foodProduct.AddOther(200, 0, "Wrapping");
            }
            return foodProduct.ToBurger();   
        }
    }
}
