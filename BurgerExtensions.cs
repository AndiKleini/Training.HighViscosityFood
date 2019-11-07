using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Cheese;
using Training.HighViscosityFood.Ingredients.Ham;
using Training.HighViscosityFood.Ingredients.Meat;
using Training.HighViscosityFood.Ingredients.Souce;

namespace Training.HighViscosityFood
{
    public static class BurgerExtensions
    {
        public static MeatPhrase AddMeat(this IFoodProduct instance, MeatType typeOfMeat)
        {
            throw new System.NotImplementedException();
        }

        public static HamPhrase AddHam(this IFoodProduct instance, HamType typeOfHam)
        {
            throw new System.NotImplementedException();
        }

        public static CheesePhrase AddCheese(this IFoodProduct instance, CheeseType typeOfCheese)
        {
            throw new System.NotImplementedException();
        }

        public static IFoodProduct AddSouce(this IFoodProduct instance, SouceType typeOfSouce)
        {
            throw new System.NotImplementedException();
        }

        public static Burger ToBurger(this IFoodProduct ingredients)
        {
            return new Burger(ingredients);
        }


    }
}
