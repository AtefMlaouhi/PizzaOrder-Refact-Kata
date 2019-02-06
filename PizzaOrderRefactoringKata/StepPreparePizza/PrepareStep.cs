using System;

namespace PizzaOrderRefactoringKata.StepPreparePizza
{
    public class PrepareStep
    {
        private string name;

        public PrepareStep(string name)
        {
            this.name = name;
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
    }
}
