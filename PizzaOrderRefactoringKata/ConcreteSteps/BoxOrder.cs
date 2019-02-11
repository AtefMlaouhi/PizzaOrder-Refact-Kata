using System;
using PizzaOrderRefactoringKata.AbstractStep;

namespace PizzaOrderRefactoringKata.ConcreteStep
{
    class BoxOrder : AbstractStepOrderPreparing
    {
        public override void Execute(AbstractPizza pizza)
        {
            pizza.Order += "Pizza in box\n";

            if (_nestStep != null)
            {
                _nestStep.Execute(pizza);
            }
        }
    }
}