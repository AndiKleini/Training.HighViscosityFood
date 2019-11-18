using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Souce;

namespace Training.HighViscosityFood.Tests.Ingrediants.Souce
{
    [TestFixture]
    public class SouceTests
    {
        [Test]
        [TestCase(SouceType.Hollandeise, 300)]
        [TestCase(SouceType.Tartar, 200)]
        public void GetMyOwnPrice_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedPrice(
            SouceType typeOfSouce,
            int expectedPrice)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(typeOfSouce);
            instanceUnderTest.GetMyOwnPrice().Should().Be(expectedPrice);
        }

        [Test]
        [TestCase(SouceType.Hollandeise, 250)]
        [TestCase(SouceType.Tartar, 110)]
        public void GetMyOwnCalories_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedCalories(
            SouceType typeOfSouce,
            int expectedCalories)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(typeOfSouce);
            instanceUnderTest.GetMyOwnCalories().Should().Be(expectedCalories);
        }
        private Ingredients.Souce.Souce GetInstanceUnderTest(SouceType typeOfSouce)
        {
            var foodIngrediantMock = new Mock<IFoodProduct>();
            return new Ingredients.Souce.Souce(
                foodIngrediantMock.Object,
                typeOfSouce);
        }
    }
}
