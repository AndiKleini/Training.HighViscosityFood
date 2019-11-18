using NUnit.Framework;
using Moq;
using FluentAssertions;
using System;
using Training.HighViscosityFood.Abstract;
using System.Globalization;

namespace Training.HighViscosityFood.Tests
{
    [TestFixture]
    public class BugerTests
    {
        [Test]
        public void ToBill_WithFoodProduct_BillListsCaloriesAndPriceFromFoodProduct()
        {
            int calories = 250;
            int price = 12;
            var orderTimeStamp = DateTime.Parse("2009-06-01T13:45:30");
            var expectedBill = new Bill()
            {
                Price = price,
                Calories = calories,
                OrderedAt = orderTimeStamp
            };
            var foodProductMock = new Mock<IFoodProduct>();
            foodProductMock.Setup(p => p.GetCalories()).Returns(calories);
            foodProductMock.Setup(p => p.GetPrice()).Returns(price);
            var burger = new Burger(foodProductMock.Object, () => orderTimeStamp);

            var bill = burger.ToBill();

            bill.Should().BeEquivalentTo(expectedBill);
        }
    }
}
