using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood.Tests.Abstract
{
    [TestFixture]
    public class WeightedIngrediantsTests
    {
        [Test]
        [TestCase(100, 100, 100)]
        [TestCase(50, 100, 50)]
        [TestCase(50, 10, 5)]
        [TestCase(20, 30, 6)]
        [TestCase(20, 5, 1)]
        [TestCase(2, 5, 0)]
        public void GetPriceForWeight_PriceForHundredGrammSupplied_MultipliedWithWeight(
            int weight,
            int pricePerHundredGramm,
            int expectedPriceForWeight)
        {
            this.GetInstanceUnderTest(weight).
                GetPriceForWeightTestExposal(pricePerHundredGramm).
                Should().Be(expectedPriceForWeight);
        }
        [Test]
        [TestCase(100, 100, 100)]
        [TestCase(50, 100, 50)]
        [TestCase(50, 10, 5)]
        [TestCase(20, 30, 6)]
        [TestCase(20, 5, 1)]
        [TestCase(2, 5, 0)]
        public void GetCaloriesForWeight_CaloriesForHundredGrammSupplied_MultipliedWithWeight(
           int weight,
           int caloriesPerHundredGramm,
           int expectedCaloriesForWeight)
        {
            this.GetInstanceUnderTest(weight).
                GetCaloriesForWeightTestExposal(caloriesPerHundredGramm).
                Should().Be(expectedCaloriesForWeight);
        }
        private WeightedIngrediantsTestExposal GetInstanceUnderTest(
            int weight)
        {
            var foodProductMock = new Mock<IFoodProduct>();
            foodProductMock.Setup(s => s.GetCalories()).Returns(0);
            foodProductMock.Setup(s => s.GetPrice()).Returns(0);

            return new WeightedIngrediantsTestExposal(
                foodProductMock.Object,
                weight);
        }
    }
}
