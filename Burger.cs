﻿using System;
using Training.HighViscosityFood.Abstract;

namespace Training.HighViscosityFood
{
    public class Burger 
    {
        private IFoodProduct underlyingFoodProduct;
        public Burger(IFoodProduct underlyingFoodProduct)
        {
            this.underlyingFoodProduct = underlyingFoodProduct;
        }
        public Bill ToBill()
        {
            return new Bill()
            {
                Calories = this.underlyingFoodProduct.GetCalories(),
                OrderedAt = DateTime.Now,
                Price = this.underlyingFoodProduct.GetPrice()
            };
        }
    }
}