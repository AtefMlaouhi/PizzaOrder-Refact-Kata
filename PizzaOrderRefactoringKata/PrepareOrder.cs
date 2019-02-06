using System;
using System.Collections.Generic;

namespace PizzaOrderRefactoringKata
{
    public class PrepareOrder : IPrepareOrder
    {
        private string name;
        private List<string> listIngredients;
        private int timeToBake;

        public PrepareOrder(string name, List<string> listIngredients, int timeToBake)
        {
            this.name = name;
            this.listIngredients = listIngredients;
            this.timeToBake = timeToBake;
        }

        public string Prepare()
        {
            if (this.name != "Dummy Pizza")
            {
                return "Pizza Order : " + name + "\n";
            }
            else
            {
                throw new NotImplementedException("this pizza is not implemented.");
            }
        }

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
