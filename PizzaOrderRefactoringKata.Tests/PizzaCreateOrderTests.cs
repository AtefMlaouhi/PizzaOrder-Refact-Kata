using System;
using NUnit.Framework;
using FluentAssertions;

namespace PizzaOrderRefactoringKata.Tests
{
    [TestFixture]
    public class PizzaCreateOrderTests
    {
        private PizzaOrder _Ipizza;
        private readonly int _Logger = 1;

        readonly static string CheesePizzaResult = "Pizza Order : Cheese Pizza\nTime To Bake : 18\nlist of ingredients : \n\tCheese\n\tCamembert\n\tMozzarella\n--------\nPizza is cutted\nPizza in box\n";
        readonly static string PepperoniPizzaResult = "Pizza Order : Pepperoni Pizza\nTime To Bake : 15\nlist of ingredients : \n\tMozzarella\n\tRed Peperoni\n\tGreen Peperoni\n\tYelloo Peperoni\n--------\nPizza is cutted\nPizza in box\n";
        readonly static string AllDressedPizzaResult = "Pizza Order : All Dressed Pizza\nTime To Bake : 12\nlist of ingredients : \n\tAnanas\n\tAvocat\n\tKewi\n--------\nPizza is cutted\nPizza in box\n";
        readonly static string VegganPizzaResult = "Pizza Order : Veggan Pizza\nTime To Bake : 14\nlist of ingredients : \n\tMozzarella\n\tCherry Tomato\n\tmushrooms\n\tRed Peperoni\n\tGreen Peperoni\n\tYelloo Peperoni\n--------\nPizza is cutted\nPizza in box\n";
        readonly static string MexicanPizzaResult = "Pizza Order : Mexican Pizza\nTime To Bake : 20\nlist of ingredients : \n\tCheese\n\tGreen Onion\n\tAvocat\n--------\nPizza is cutted\nPizza in box\n";


        [SetUp]
        public void InitTest()
        {
            this._Ipizza = new PizzaOrder(this._Logger);
        }

        [TearDown]
        public void ClearTest()
        {
            this._Ipizza = null;
        }

        [Test]
        [Description("Cheese Pizza")]
        public void PizzaOrder_Should_Be_Return_CheesePizza_When_CreateOrder_Is_Called()
        {
            var result = this._Ipizza.CreateOrder("Cheese Pizza");
            result.Should().BeOfType<string>().And.NotBeNull().And.Equals(CheesePizzaResult);
        }

        [Test]
        [Description("Pepperoni Pizza")]
        public void PizzaOrder_Should_Be_Return_Pepperoni_Pizza_When_CreateOrder_Is_Called()
        {
            var result = this._Ipizza.CreateOrder("Pepperoni Pizza");
            result.Should().BeOfType<string>().And.NotBeNull().And.Equals(PepperoniPizzaResult);
        }

        [Test]
        [Description("All Dressed Pizza")]
        public void PizzaOrder_Should_Be_Return_All_Dressed_Pizza_When_CreateOrder_Is_Called()
        {
            var result = this._Ipizza.CreateOrder("All Dressed Pizza");
            result.Should().BeOfType<string>().And.NotBeNull().And.Equals(AllDressedPizzaResult);
        }

        [Test]
        [Description("Veggan Pizza")]
        public void PizzaOrder_Should_Be_Return_Veggan_Pizza_When_CreateOrder_Is_Called()
        {
            var result = this._Ipizza.CreateOrder("Veggan Pizza");
            result.Should().BeOfType<string>().And.NotBeNull().And.Equals(VegganPizzaResult);
        }

        [Test]
        [Description("Mexican Pizza")]
        public void PizzaOrder_Should_Be_Return_Mexican_Pizza_When_CreateOrder_Is_Called()
        {
            var result = this._Ipizza.CreateOrder("Mexican Pizza");
            result.Should().BeOfType<string>().And.NotBeNull().And.Equals(MexicanPizzaResult);
        }

        [Test]
        [Description("Dummy Pizza")]
        public void PizzaOrder_Should_Be_Return_NotImplementedException_When_CreateOrder_Is_Called_With_Dummy_Pizza()
        {
            Assert.Throws<NotImplementedException>(() => this._Ipizza.CreateOrder("Dummy Pizza"));
        }
    }
}
