using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderRefactoringKata
{
    public class IPizza
    {
        private string name;
        private List<string> listIngredients;
        private int timeToBake;
        private PrepareOrder prepareOrder;

        public IPizza(string name, List<string> listIngredients, int timeToBake)
        {
            this.name = name;
            this.listIngredients = listIngredients;
            this.timeToBake = timeToBake;
            prepareOrder = new PrepareOrder(name, listIngredients, timeToBake);
        }

        public string createOrder()
        {
            string order = "";
            order += prepareOrder.Prepare();
            order += prepareOrder.Bake();
            order += prepareOrder.Cut();
            order += prepareOrder.Box();
            return order;
        }
    }
}
