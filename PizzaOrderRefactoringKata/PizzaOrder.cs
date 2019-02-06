using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    public class PizzaOrder
    {
        private ILogger logger;

        public PizzaOrder(int loggerType)
        {
            if (loggerType == 0)
            {
                logger = new Logger();
            }
            else if (loggerType == 1)
            {
                logger = new ConsoleLogger();
            }
        }

        public String CreateOrder(String name)
        {
            string result = string.Empty;

            if (name == "Cheese Pizza")
            {
                result = new IPizza(name, new List<string>() {"Cheese", "Camembert", "Mozzarella" }, 18).createOrder();
            }
            else if (name == "Pepperoni Pizza")
            {
                result = new IPizza(name, new List<string>() { "Mozzarella", "Red Peperoni", "Green Peperoni", "Yelloo Peperoni" }, 15).createOrder();
            }
            else if (name == "All Dressed Pizza")
            {
                result = new IPizza(name, new List<string>() { "Ananas", "Avocat", "Kewi" }, 12).createOrder();
            }
            else if (name == "Veggan Pizza")
            {
                result = new IPizza(name, new List<string>() { "Mozzarella", "Cherry Tomato", "mushrooms", "Red Peperoni", "Green Peperoni", "Yelloo Peperoni" }, 14).createOrder();
            }
            else if (name == "Mexican Pizza")
            {
                result = new IPizza(name, new List<string>() { "Cheese", "Green Onion", "Avocat" }, 20).createOrder();
            }
            else if(name == "Dummy Pizza")
            {
                result = new IPizza(name, new List<string>(), 20).createOrder();
            }

            return result;
        }
    }
}
