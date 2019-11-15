using NUnit.Framework;
using Moq;
using Training.HighViscosityFood.Abstract;
using FluentAssertions;

namespace Training.HighViscosityFood.Tests.Abstract
{
    [TestFixture]
    public class IngrediantsBaseTests
    {
        [Test]
        public void GetCalories_OwnCaloriesSet_EmitSumOfOwnAndDecoratedCalories()
        {
            int foodProductCalories = 200;
            int foodProductPrice = 12;
            var foodProductMock = new Mock<IFoodProduct>();
            foodProductMock.Setup(e => e.GetCalories()).Returns(foodProductCalories);
            foodProductMock.Setup(e => e.GetPrice()).Returns(foodProductPrice);
            int ownCalories = 50;
            int ownPrice = 45;
            var instanceUnderTest = new IngrediantsBaseTestExposal(
                foodProductMock.Object,
                ownCalories,
                ownPrice);

            instanceUnderTest.GetCalories().Should().Be(ownCalories + foodProductCalories);
        }
        [Test]
        public void GetPrice_OwnPriceSet_EmitSumOfOwnAndDecoratedPrices()
        {
            int foodProductCalories = 200;
            int foodProductPrice = 12;
            var foodProductMock = new Mock<IFoodProduct>();
            foodProductMock.Setup(e => e.GetCalories()).Returns(foodProductCalories);
            foodProductMock.Setup(e => e.GetPrice()).Returns(foodProductPrice);
            int ownCalories = 50;
            int ownPrice = 45;
            var instanceUnderTest = new IngrediantsBaseTestExposal(
                foodProductMock.Object,
                ownCalories,
                ownPrice);

            instanceUnderTest.GetPrice().Should().Be(ownPrice + foodProductPrice);
        }
    }
}
