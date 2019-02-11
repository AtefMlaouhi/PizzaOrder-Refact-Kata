using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaOrderRefactoringKata.AcceptPizzaType
{
    public interface IPizzaVisitor
    {
        void Visit(DommyPizza pizza);
        void Visit(RealPizza pizza);
    }
}
