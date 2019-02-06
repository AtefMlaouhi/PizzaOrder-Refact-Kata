using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderRefactoringKata.StepPreparePizza
{
    public class BakeStep
    {
        private int timeToBake;
        private IList<string> listIngredients;

        public BakeStep(int timeToBake, IList<string> listIngredients)
        {
            this.timeToBake = timeToBake;
            this.listIngredients = listIngredients;
        }

        public string Bake()
        {
            string pizza = "Time To Bake : " + timeToBake + "\n";
            pizza += this.GetIngredients();
            return pizza;
        }

        private string GetIngredients()
        {
            string pizza = "list of ingredients : ";


            for (int i = 0; i < this.listIngredients.Count; i++)
            {
                pizza += "\n\t" + this.listIngredients[i];
            }

            pizza += "\n--------\n";

            return pizza;
        }
    }
}
