using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaOrderRefactoringKata.AcceptPizzaType
{
    public class PizzaVisitor : IPizzaVisitor
    {
        public void Visit(RealPizza pizza)
        {
        }

        public void Visit(DommyPizza pizza)
        {
            throw new NotImplementedException("this pizza is not implemented.");
        }
    }
}
