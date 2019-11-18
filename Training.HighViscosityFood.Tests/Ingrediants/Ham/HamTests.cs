using FluentAssertions;
using Moq;
using NUnit.Framework;
using Training.HighViscosityFood.Abstract;
using Training.HighViscosityFood.Ingredients.Ham;

namespace Training.HighViscosityFood.Tests.Ingrediants.Ham
{
    [TestFixture]
    public class HamTests
    {
        [Test]
        [TestCase(100, HamType.BlackForest, 195)]
        [TestCase(50, HamType.BlackForest, 97)]
        [TestCase(150, HamType.BlackForest, 292)]
        [TestCase(100, HamType.Pancetta, 170)]
        [TestCase(50, HamType.Pancetta, 85)]
        [TestCase(150, HamType.Pancetta, 255)]
        public void GetMyOwnPrice_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedPrice(
            int weight, 
            HamType typeOfHam,
            int expectedPrice)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(weight, typeOfHam);
            instanceUnderTest.GetMyOwnPrice().Should().Be(expectedPrice);
        }
        
        [Test]
        [TestCase(100, HamType.BlackForest, 143)]
        [TestCase(50, HamType.BlackForest, 71)]
        [TestCase(150, HamType.BlackForest, 214)]
        [TestCase(100, HamType.Pancetta, 120)]
        [TestCase(50, HamType.Pancetta, 60)]
        [TestCase(150, HamType.Pancetta, 180)]
        public void GetMyOwnCalories_WeightAndTypeSpecified_EmitsWeightAndTypeRelatedCalories(
            int weight,
            HamType typeOfHam,
            int expectedCalories)
        {
            var instanceUnderTest = this.GetInstanceUnderTest(weight, typeOfHam);
            instanceUnderTest.GetMyOwnCalories().Should().Be(expectedCalories);
        }
        private Ingredients.Ham.Ham GetInstanceUnderTest(int weight, HamType typeOfHam)
        {
            var foodIngrediantMock = new Mock<IFoodProduct>();
            return new Ingredients.Ham.Ham(
                foodIngrediantMock.Object,
                weight,
                typeOfHam);
        }
    }
}
