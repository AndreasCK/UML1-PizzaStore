using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Pizza
    {
        #region
        string _name;
        string _pizzatopping;
        int _pizzaprice;
        #endregion

        #region
        public Pizza()
        {
            _name = "";
            _pizzatopping = "";
            _pizzaprice = 0;

        }
        #endregion

        #region
        public Pizza(string Name, string PizzaTopping, int PizzaPrice)
        {
            _name = Name;
            _pizzatopping = PizzaTopping;
            _pizzaprice = PizzaPrice;
        }
        #endregion

        #region
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PizzaTopping
        {
            get { return _pizzatopping; }
            set { _pizzatopping = value; }
        }

        public int PizzaPrice
        {
            get { return _pizzaprice; }
            set { _pizzaprice = value; }
        }
        #endregion

        #region
        public override string ToString()
        {
            return $"Name: {Name} PizzaTopping: {PizzaTopping} PizzaPrice: {PizzaPrice}";  
        }
        #endregion
    }







}
