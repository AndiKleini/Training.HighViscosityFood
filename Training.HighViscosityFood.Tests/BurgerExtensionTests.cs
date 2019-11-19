﻿using NUnit.Framework;
using Training.HighViscosityFood.Ingredients.Souce;
using FluentAssertions;
using Training.HighViscosityFood.Ingredients.Base;
using Training.HighViscosityFood.Ingredients.Meat;
using Training.HighViscosityFood.Ingredients.Cheese;
using Training.HighViscosityFood.Ingredients.Ham;
using Training.HighViscosityFood.Ingredients.Other;

namespace Training.HighViscosityFood.Tests
{
    [TestFixture]
    public class BurgerExtensionTests
    {
        [Test]
        public void AddSouce_ToFoodProduct_DecoratedToSouce()
        {
            this.CreateBaseFoodProduct().
                AddSouce(SouceType.Hollandeise).
                Should().
                BeOfType<Souce>();
        }
        [Test]
        public void AddMeat_ToFoodProduct_EmitMeatPhrase()
        {
            this.CreateBaseFoodProduct().
                AddMeat(MeatType.Seafood).
                Should().
                BeOfType<MeatPhrase>();
        }
        [Test]
        public void AddCheese_ToFoodProduct_EmitCheesePhrase()
        {
            this.CreateBaseFoodProduct().
                AddCheese(CheeseType.CottageCheese).
                Should().
                BeOfType<CheesePhrase>();
        }
        [Test]
        public void AddHam_ToFoodProduct_EmitHamPhrase()
        {
            this.CreateBaseFoodProduct().
                AddHam(HamType.BlackForest).
                Should().
                BeOfType<HamPhrase>();
        }
        [Test]
        public void AddOther_ToFoodProduct_EmitOther()
        {
            this.CreateBaseFoodProduct().
                AddOther(10, 200, "some other product").
                Should().
                BeOfType<Other>();
        }
        private Base CreateBaseFoodProduct()
        {
            return new Base();
        }
    }
}
