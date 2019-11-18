using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Ham;

namespace Training.HighViscosityFood.Tests.Ingrediants.Ham
{
    [TestFixture]
    public class HamPhraseTests
    {
        [Test]
        public void OfWeight_WeightIsSpecified_ReturnsInstanceOfTypeCheese()
        {
            var foodProductMock = new Mock<IFoodProduct>();
            new HamPhrase(foodProductMock.Object, HamType.Pancetta).
                OfWeight(100).Should().
                BeOfType<Ingredients.Ham.Ham>();
        }
    }
}
