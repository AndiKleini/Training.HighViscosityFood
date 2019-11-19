# Training.HighViscosityFood
An example for too high complexity and viscosity in design.

This repository contains a training project for dealing with viscosity in design. By comparing three different branches, that are simulating a real world development scenario, one can see the impact of high viscosity on design during ongoing development. It helps to understand the problem and let one think about design preserving elements in code.

## The background story

Like in any other software project, a small backgroundstory of involved developers can be related. 

### The first (basic) version

Once upon a time Clare, who is a very experienced software developer, was hired to create a system for some food corner. The business was young and the budget was low. Consequently Clare developed some basic features into the system to enable the business and make selling food possible. This initial, basic version can be checked out on master branch. Customers were lucky and started their business.

```C#
        public Burger GetClassicBurger()
        {
            return new Base().
                AddCheese(Ingredients.Cheese.CheeseType.Tilsitter).
                OfWeight(200).
                AddHam(Ingredients.Ham.HamType.Pancetta).
                OfWeight(300).
                AddSouce(Ingredients.Souce.SouceType.Hollandeise).
                ToBurger();
        }
```

By designing the solution, Clare had in mind the next feature of generating a printed out bill. This leads to application of decorator pattern and abstraction to FoodIngrediantsBase (IFoodProduct). But Clare had no chance, to talk to anyone else about it.

### Eddies changes 

After some weeks it figured out that more and more customers prefered taking away the food instead of eating it in the food corner. This implies the need of wrapping the meal. Stackholders decide to let their customers pay for it, which resulted in a new feature:
Wrap the food and let the customers pay a fixed price of 200 for it.

Unfortunetly Clare was on holiday and her workmate Eddy was asked to develop the feature. Eddie is also very experienced and he quickly found a solution for it. Eddies extensions were fine and also very simple and easy to understand. Nonetheless he violated, without really wanting it, Clares design. Befor you judge Eddy, please by aware that he has no idea about Clares plans regarding the bill.

You can go through Eddies concise and intuitive changes in branch SellOptionalWrapping_ByEddy.

### Clare returns from holiday

When Clare returns from her holidays, she checked out Eddies branch and was very unlucky about the design breaking changes. She knows that Eddy is a great developer and tries to understand how this could happen. After some review on her design, she came to the conclusion that viscosity in her design was too high. It was much more easier hacking around, than following the design. Adding this simple wrapping feature was not supported by existing design. 

Clare has to change it. Otherwise she would not support the bill printing feature. Clare found an easy way to add abitrary (untyped) food products to her system. Therfore she created the class Other, deriving from IngrediantsBase. This class represents a fully paramterizable FoodProduct that can be easily used for adding any kind of ingrediant.

One can review Clares changes on branch SellOptionalWrapping_ByClare.

Code below shows you, how a burger can be wrapped and the price is increased by 200.

```C#
        public Burger GetClassicBurger()
        {
            return new Base().
                AddCheese(Ingredients.Cheese.CheeseType.Tilsitter).
                OfWeight(200).
                AddHam(Ingredients.Ham.HamType.Pancetta).
                OfWeight(300).
                AddSouce(Ingredients.Souce.SouceType.Hollandeise).
                AddOther(200, 0, "Wrapping").
                ToBurger();
        }
```
For adding abitrary stuff to a food product, the general ingrediant type Other was introduced (the name ingrediant is somehow misleading now ...). As beeing a decorator it fits perfectly to the existing design and will also support upcoming bill feature.

```C#
    internal class Other : IngrediantsBase
    {
        private int price;
        private int calories;
        private string name;
        public Other(
            IFoodProduct decoratedInstance,
            int price,
            int calories,
            string name) :
            base(decoratedInstance)
        {
            this.price = price;
            this.calories = calories;
            this.name = name;
        }
        internal override int GetMyOwnCalories()
        {
            return this.calories;
        }
        internal override int GetMyOwnPrice()
        {
            return this.price;
        }
    }
```

## Tips for training

After a short introduction about viscosity and aspects of agile architecture, the trainer can introduce the example by going quickly through the master branch. Next, developers can step into role of Eddy and create the wrapping feature. After 10 - 15 minutes each solution is presented. It is up to the teacher now to moderate and extract as much value as possible.






