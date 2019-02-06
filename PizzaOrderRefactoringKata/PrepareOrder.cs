using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    using StepPreparePizza;

    public class PrepareOrder : IPrepareOrder
    {
        private PrepareStep _PrepareStep;
        private BakeStep _BakeStep;

        public PrepareOrder(string name, List<string> listIngredients, int timeToBake)
        {
            this._PrepareStep = new PrepareStep(name);
            this._BakeStep = new BakeStep(timeToBake, listIngredients);
        }

        public string Prepare() => this._PrepareStep.Prepare();

        public string Bake() => this._BakeStep.Bake();


        public string Cut()
        {
            return "Pizza is cutted\n";
        }

        public string Box()
        {
            return "Pizza in box\n";
        }
    }
}
