using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaOrderRefactoringKata.AbstractStep
{
    public abstract class AbstractStepOrderPreparing
    {
        protected AbstractStepOrderPreparing _nestStep;

        public void SetNextStep(AbstractStepOrderPreparing nestStep)
        {
            _nestStep = nestStep;
        }

        public abstract void Execute(AbstractPizza pizza);
    }
}
