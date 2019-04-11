using System.Collections.Generic;
using System.Text;

namespace StaticExmple
{
    class Pizza
    {
        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }

        private string name;
        static List<Pizza> pizzas = new List<Pizza>();
        List<Pizza> pizzas2 = new List<Pizza>();
        public Pizza(string name)
        {
            this.name = name;
            Pizza mix = new Pizza("mix");
            Pizza fix = new Pizza("fix");
            Pizza eix = new Pizza("eix");
            Pizza bix = new Pizza("bix");
            pizzas.Add(mix);
            pizzas.Add(fix);
            if (name == "margarita")
            {
                pizzas2.Add(new Pizza("margarita"));
                pizzas2.Add(new Pizza("margarita"));
                pizzas2.Add(new Pizza("margarita"));
            }

            if (name == "house")
            {
                pizzas.Add(new Pizza("house"));
                pizzas.Add(new Pizza("house"));
                pizzas.Add(new Pizza("house"));
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            StringBuilder se = new StringBuilder();
            foreach (Pizza pizza in pizzas)
            {
                s.Append(pizza.Name + " : ");
            }

            foreach (Pizza pizza in pizzas2)
            {
                se.Append(pizza.Name + ": ");
            }
            return "This pizza is a " + name + " and inside this pizza is a list of other pizzas this is a statics list " + s;
        }
    }
}