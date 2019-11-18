using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Meat;

namespace Training.HighViscosityFood.Tests.Ingrediants.Meat
{
    [TestFixture]
    public class MeatPhraseTests
    {
        [Test]
        public void OfWeight_WeightIsSpecified_ReturnsInstanceOfTypeCheese()
        {
            var foodProductMock = new Mock<IFoodProduct>();
            new MeatPhrase(foodProductMock.Object, MeatType.Seafood).
                OfWeight(100).Should().
                BeOfType < Ingredients.Meat.Meat>();
        }
    }
}
