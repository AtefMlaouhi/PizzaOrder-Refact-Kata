using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    public class PizzaOrder
    {
        private ILogger _logger;

        public PizzaOrder(int loggerType)
        {
            if (loggerType == 0)
            {
                _logger = new Logger();
            }
            else if (loggerType == 1)
            {
                _logger = new ConsoleLogger();
            }
        }

        public String CreateOrder(String name)
        {
            string result = string.Empty;

            if (name == "Cheese Pizza")
            {
                result = new IPizza(name, new List<string>() {"Cheese", "Camembert", "Mozzarella" }, 18).CreateOrder();
            }
            else if (name == "Pepperoni Pizza")
            {
                result = new IPizza(name, new List<string>() { "Mozzarella", "Red Peperoni", "Green Peperoni", "Yelloo Peperoni" }, 15).CreateOrder();
            }
            else if (name == "All Dressed Pizza")
            {
                result = new IPizza(name, new List<string>() { "Ananas", "Avocat", "Kewi" }, 12).CreateOrder();
            }
            else if (name == "Veggan Pizza")
            {
                result = new IPizza(name, new List<string>() { "Mozzarella", "Cherry Tomato", "mushrooms", "Red Peperoni", "Green Peperoni", "Yelloo Peperoni" }, 14).CreateOrder();
            }
            else if (name == "Mexican Pizza")
            {
                result = new IPizza(name, new List<string>() { "Cheese", "Green Onion", "Avocat" }, 20).CreateOrder();
            }
            else if(name == "Dummy Pizza")
            {
                result = new IPizza(name, new List<string>(), 20).CreateOrder();
            }

            return result;
        }
    }
}
