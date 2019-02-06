using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    using StepPreparePizza;

    public class PrepareOrder : IPrepareOrder
    {
        private string name;
        private List<string> listIngredients;
        private int timeToBake;

        private PrepareStep _prepareStep; 

        public PrepareOrder(string name, List<string> listIngredients, int timeToBake)
        {
            this.name = name;
            this.listIngredients = listIngredients;
            this.timeToBake = timeToBake;

            this._prepareStep = new PrepareStep(this.name);
        }

        public string Prepare() => this._prepareStep.Prepare();
        

        public string Bake()
        {
            String pizza = "Time To Bake : " + timeToBake + "\n";
            pizza += this.GetIngredients();
            return pizza;
        }

        public string Cut()
        {
            return "Pizza is cutted\n";
        }

        public string Box()
        {
            return "Pizza in box\n";
        }

        private String GetIngredients()
        {
            String pizza = "list of ingredients : ";


            for (int i = 0; i < this.listIngredients.Count; i++)
            {
                pizza += "\n\t" + this.listIngredients[i];
            }

            pizza += "\n--------\n";

            return pizza;
        }
    }
}
