using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Cheese;

namespace Training.HighViscosityFood.Tests.Ingrediants.Cheese
{
    [TestFixture]
    public class CheeseTests
    {
        [Test]
        [TestCase(100, CheeseType.CottageCheese, 10)]
        [TestCase(50, CheeseType.CottageCheese, 5)]
        [TestCase(150, CheeseType.CottageCheese, 15)]
        [TestCase(100, CheeseType.Tilsitter, 50)]
        [TestCase(50, CheeseType.Tilsitter, 25)]
        [TestCase(150, CheeseType.Tilsitter, 75)]
        [TestCase(100, CheeseType.Edamer, 60)]
        [TestCase(50, CheeseType.Edamer, 30)]
        [TestCase(150, CheeseType.Edamer, 90)]
        public void GetMyOwnPrice_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedPrice(
            int weight, 
            CheeseType typeOfCheese,
            int expectedPrice)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(weight, typeOfCheese);
            instanceUnderTest.GetMyOwnPrice().Should().Be(expectedPrice);
        }
        [Test]
        [TestCase(100, CheeseType.CottageCheese, 87)]
        [TestCase(50, CheeseType.CottageCheese, 43)]
        [TestCase(150, CheeseType.CottageCheese, 130)]
        [TestCase(100, CheeseType.Tilsitter, 70)]
        [TestCase(50, CheeseType.Tilsitter, 35)]
        [TestCase(150, CheeseType.Tilsitter, 105)]
        [TestCase(100, CheeseType.Edamer, 110)]
        [TestCase(50, CheeseType.Edamer, 55)]
        [TestCase(150, CheeseType.Edamer, 165)]
        public void GetMyOwnCalories_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedCalories(
            int weight,
            CheeseType typeOfCheese,
            int expectedCalories)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(weight, typeOfCheese);
            instanceUnderTest.GetMyOwnCalories().Should().Be(expectedCalories);
        }
        private Ingredients.Cheese.Cheese GetInstanceUnderTest(int weight, CheeseType typeOfCheese)
        {
            var foodIngrediantMock = new Mock<IFoodProduct>();
            return new Ingredients.Cheese.Cheese(
                foodIngrediantMock.Object,
                weight,
                typeOfCheese);
        }
    }
}
