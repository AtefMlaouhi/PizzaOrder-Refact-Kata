using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    using AbstractStep;
    using ConcreteStep;

    public class PrepareOrder : IPrepareOrder
    {
        private AbstractStepOrderPreparing _AcceptOrder;
        private AbstractPizza Pizza;

        private string Name { get; set; }
        private IList<string> ListIngredients { get; set; }
        private int TimeToBake { get; set; }


        public PrepareOrder(string name, IList<string> listIngredients, int timeToBake)
        {
            _AcceptOrder = new AcceptOrder();
            AbstractStepOrderPreparing _BakeOrder = new BakeOrder();
            AbstractStepOrderPreparing _CutOrder = new CutOrder();
            AbstractStepOrderPreparing _BoxOrder = new BoxOrder();
            _AcceptOrder.SetNextStep(_BakeOrder);
            _BakeOrder.SetNextStep(_CutOrder);
            _CutOrder.SetNextStep(_BoxOrder);

            this.Name = name;
            this.ListIngredients = listIngredients;
            this.TimeToBake = timeToBake;

        }

        public string PrintOrder()
        {
            if (this.Name.Contains("Dummy"))
            {
                Pizza = new DommyPizza();
            }
            else
            {
                Pizza = new RealPizza();
            }

            this.Pizza.PizzaName = this.Name;
            this.Pizza.TimeToBake = this.TimeToBake;
            this.Pizza.ListIngredient = this.ListIngredients;

            this._AcceptOrder.Execute(Pizza);
            return this.Pizza.Order;
        }
    }
}
