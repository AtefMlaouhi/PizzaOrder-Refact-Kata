using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderRefactoringKata
{
    public class IPizza
    {
        private PrepareOrder prepareOrder;

        public IPizza(string name, List<string> listIngredients, int timeToBake)
        {
            prepareOrder = new PrepareOrder(name, listIngredients, timeToBake);
        }

        public string CreateOrder()
        {
            return this.prepareOrder.PrintOrder();
        }
    }
}
