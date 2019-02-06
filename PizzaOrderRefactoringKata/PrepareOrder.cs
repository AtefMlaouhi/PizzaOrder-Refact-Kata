using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    using StepPreparePizza;

    public class PrepareOrder : IPrepareOrder
    {
        private PrepareStep _PrepareStep;
        private BakeStep _BakeStep;
        private CutStep _CutStep;

        public PrepareOrder(string name, List<string> listIngredients, int timeToBake)
        {
            this._PrepareStep = new PrepareStep(name);
            this._BakeStep = new BakeStep(timeToBake, listIngredients);
            this._CutStep = new CutStep();
        }

        public string Prepare() => this._PrepareStep.Prepare();

        public string Bake() => this._BakeStep.Bake();

        public string Cut() => this._CutStep.Cut();

        public string Box()
        {
            return "Pizza in box\n";
        }
    }
}
