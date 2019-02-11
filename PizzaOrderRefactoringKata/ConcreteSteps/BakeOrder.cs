using System;
using System.Collections.Generic;
using PizzaOrderRefactoringKata.AbstractStep;

namespace PizzaOrderRefactoringKata.ConcreteStep
{
    public class BakeOrder : AbstractStepOrderPreparing
    {
        public override void Execute(AbstractPizza pizza)
        {
            pizza.Order += "Time To Bake : " + pizza.TimeToBake + "\n";
            pizza.Order += this.GetIngredients(pizza.ListIngredient);

            if (_nestStep != null)
            {
                _nestStep.Execute(pizza);
            }
        }

        private string GetIngredients(IList<string> listIngredients)
        {
            string pizza = "list of ingredients : ";


            for (int i = 0; i < listIngredients.Count; i++)
            {
                pizza += "\n\t" + listIngredients[i];
            }

            pizza += "\n--------\n";

            return pizza;
        }
    }
}