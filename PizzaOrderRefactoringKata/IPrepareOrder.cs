using System;
namespace PizzaOrderRefactoringKata
{
    public interface IPrepareOrder
    {
        string Prepare();
        string Bake();
        string Cut();
        string Box();
    }
}
