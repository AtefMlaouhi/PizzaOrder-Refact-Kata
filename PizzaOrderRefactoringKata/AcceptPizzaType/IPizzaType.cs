namespace PizzaOrderRefactoringKata.AcceptPizzaType
{
    using PizzaOrderRefactoringKata;
    using System.Collections.Generic;

    public interface IPizzaType
    {
        string PizzaName { get; set; }
        IList<string> ListIngredient { get; set; }
        int TimeToBake { get; set; }
        string Order { get; set; }
        void Accept(IPizzaVisitor pizzaType);
    }
}
