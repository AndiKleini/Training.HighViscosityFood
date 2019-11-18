using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Cheese;

namespace Training.HighViscosityFood.Tests.Ingrediants.Cheese
{
    [TestFixture]
    public class CheesePhraseTests
    {
        [Test]
        public void OfWeight_WeightIsSpecified_ReturnsInstanceOfTypeCheese()
        {
            var foodProductMock = new Mock<IFoodProduct>();
            new CheesePhrase(foodProductMock.Object, CheeseType.Edamer).
                OfWeight(100).Should().
                BeOfType<Ingredients.Cheese.Cheese>();
        }
    }
}
