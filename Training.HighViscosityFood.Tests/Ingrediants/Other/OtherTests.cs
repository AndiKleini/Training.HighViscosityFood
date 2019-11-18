using NUnit.Framework;
using Moq;
using Training.HighViscosityFood.Abstract;
using FluentAssertions;

namespace Training.HighViscosityFood.Tests.Ingrediants.Other
{
    [TestFixture]
    public class OtherTests
    {
        [Test]
        public void GetMyOwnPrice_PriceSpecified_EmitsSpecifiedPrice()
        {
            int price = 50;
            int calories = 0;
            new Training.HighViscosityFood.Ingredients.Other.Other(
                    new Moq.Mock<IFoodProduct>().Object,
                    price, 
                    calories,
                    "somename").
                    GetMyOwnPrice().Should().Be(price);
        }

        [Test]
        public void GetMyOwnCalories_CaloriesAreSpecified_EmitsSpecifiedCalories()
        {
            int price = 0;
            int calories = 34;
            new Training.HighViscosityFood.Ingredients.Other.Other(
                    new Moq.Mock<IFoodProduct>().Object,
                    price,
                    calories,
                    "somename").
                    GetMyOwnCalories().Should().Be(calories);
        }
    }
}
