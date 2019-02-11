using System;
using PizzaOrderRefactoringKata.AbstractStep;

namespace PizzaOrderRefactoringKata.ConcreteStep
{
    class CutOrder : AbstractStepOrderPreparing
    {
        public override void Execute(AbstractPizza pizza)
        {
            pizza.Order += "Pizza is cutted\n"; ;

            if (_nestStep != null)
            {
                _nestStep.Execute(pizza);
            }
        }
    }
}