using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Cheese;
using Training.HighViscosityFood.Ingredients.Ham;
using Training.HighViscosityFood.Ingredients.Meat;
using Training.HighViscosityFood.Ingredients.Other;
using Training.HighViscosityFood.Ingredients.Souce;

namespace Training.HighViscosityFood
{
    public static class BurgerExtensions
    {
        public static MeatPhrase AddMeat(this IFoodProduct instance, MeatType typeOfMeat)
        {
            return new MeatPhrase(instance, typeOfMeat);
        }
        public static HamPhrase AddHam(this IFoodProduct instance, HamType typeOfHam)
        {
            return new HamPhrase(instance, typeOfHam);
        }
        public static CheesePhrase AddCheese(this IFoodProduct instance, CheeseType typeOfCheese)
        {
            return new CheesePhrase(instance, typeOfCheese);
        }
        public static IFoodProduct AddSouce(this IFoodProduct instance, SouceType typeOfSouce)
        {
            return new Souce(instance, typeOfSouce);
        }
        public static IFoodProduct AddOther(this IFoodProduct instance, int price,
            int calories,
            string name)
        {
            return new Other(instance, price, calories, name);
        }
        public static Burger ToBurger(this IFoodProduct ingredients)
        {
            return new Burger(ingredients);
        }
    }
}
