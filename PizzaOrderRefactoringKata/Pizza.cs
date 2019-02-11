using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaOrderRefactoringKata.AcceptPizzaType;

namespace PizzaOrderRefactoringKata
{
    public abstract class AbstractPizza : IPizzaType
    {
        public string PizzaName { get; set; }
        public IList<string> ListIngredient { get; set; }
        public int TimeToBake { get; set; }
        public string Order { get; set; }

        public virtual void Accept(IPizzaVisitor pizzaType)
        {
        }
    }

    public class RealPizza : AbstractPizza, IPizzaType
    {
        public override void Accept(IPizzaVisitor pizzaType)
        {
            pizzaType.Visit(this);
        }
    }

    public class DommyPizza: AbstractPizza, IPizzaType
    {
        public override void Accept(IPizzaVisitor pizzaType)
        {
            pizzaType.Visit(this);
        }
    }
}
