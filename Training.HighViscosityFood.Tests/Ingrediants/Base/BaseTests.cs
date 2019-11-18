using FluentAssertions;
using NUnit.Framework;

namespace Training.HighViscosityFood.Tests.Ingrediants.Base
{
    [TestFixture]
    public class BaseTests
    {
        [Test]
        public void GetPrice_ReturnsFixedCosts()
        {
            new Ingredients.Base.Base().GetPrice().Should().Be(200);
        }

        [Test]
        public void GetCalories_ReturnsZero()
        {
            new Ingredients.Base.Base().GetCalories().Should().Be(0);
        }
    }
}
