using System;
using PizzaOrderRefactoringKata.AbstractStep;
using PizzaOrderRefactoringKata.AcceptPizzaType;

namespace PizzaOrderRefactoringKata.ConcreteStep
{
    public class AcceptOrder : AbstractStepOrderPreparing
    {

        public override void Execute(AbstractPizza pizza)
        {
            pizza.Accept(new PizzaVisitor());

            pizza.Order += "Pizza Order : " + pizza.PizzaName + "\n";

            if (_nestStep != null)
            {
                _nestStep.Execute(pizza);
            }
        }
    }
}