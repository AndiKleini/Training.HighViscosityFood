using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Meat;

namespace Training.HighViscosityFood.Tests.Ingrediants.Meat
{
    [TestFixture]
    public class MeatTests
    {
        [Test]
        [TestCase(100, MeatType.Pork, 130)]
        [TestCase(50, MeatType.Pork, 65)]
        [TestCase(150, MeatType.Pork, 195)]
        [TestCase(100, MeatType.Seafood, 230)]
        [TestCase(50, MeatType.Seafood, 115)]
        [TestCase(150, MeatType.Seafood, 345)]
        public void GetMyOwnPrice_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedPrice(
            int weight, 
            MeatType typeOfMeat,
            int expectedPrice)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(weight, typeOfMeat);
            instanceUnderTest.GetMyOwnPrice().Should().Be(expectedPrice);
        }
        
        [Test]
        [TestCase(100, MeatType.Pork, 78)]
        [TestCase(50, MeatType.Pork, 39)]
        [TestCase(150, MeatType.Pork, 117)]
        [TestCase(100, MeatType.Seafood, 250)]
        [TestCase(50, MeatType.Seafood, 125)]
        [TestCase(150, MeatType.Seafood, 375)]
        public void GetMyOwnCalories_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedCalories(
            int weight,
            MeatType typeOfMeat,
            int expectedCalories)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(weight, typeOfMeat);
            instanceUnderTest.GetMyOwnCalories().Should().Be(expectedCalories);
        }
        private Ingredients.Meat.Meat GetInstanceUnderTest(int weight, MeatType typeOfMeat)
        {
            var foodIngrediantMock = new Mock<IFoodProduct>();
            return new Ingredients.Meat.Meat(
                foodIngrediantMock.Object,
                weight,
                typeOfMeat);
        }
    }
}
