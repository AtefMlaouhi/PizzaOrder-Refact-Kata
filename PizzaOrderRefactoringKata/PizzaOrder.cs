using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    public class PizzaOrder
    {
        private ILogger logger;

        PizzaOrder(int loggerType)
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

        public String CreatePizza(String name)
        {
            if (name == "Cheese Pizza")
            {
                return new IPizza(name, new List<string>() {"Cheese", "Camembert", "Mozzarella" }, 18).createOrder();
            }
            else if (name == "Pepperoni Pizza")
            {
                return new IPizza(name, new List<string>() { "Red Peperoni", "Green Peperoni", "Yelloo Peperoni" }, 15).createOrder();
            }
            else if (name == "All dressed Pizza")
            {
                return new IPizza(name, new List<string>() { "Cheese", "Camembert", "Mozzarella" }, 12).createOrder();
            }
            else if (name == "Veggan Pizza")
            {
                return new IPizza(name, new List<string>() { "Cheese", "Camembert", "Mozzarella" }, 14).createOrder();
            }
            else if (name == "Mexican Pizza")
            {
                return new IPizza(name, new List<string>() { "Cheese", "Camembert", "Mozzarella" }, 20).createOrder();
            }
            return String.Empty;
        }
    }
}
