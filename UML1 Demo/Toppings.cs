using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Toppings
    {
        #region
        string _toppingType;
        int _toppingPrice;
        #endregion

        #region
        public Toppings()
        {
            _toppingType = "";
            _toppingPrice = 0;
        }
        #endregion

        public Toppings(string ToppingType, int ToppingPrice)
        {
            _toppingType = ToppingType;
            _toppingPrice = ToppingPrice;
        }

        public string ToppingType
        {
            get { return _toppingType; }
            set { _toppingType = value; }
        }

        public int ToppingPrice
        {
            get { return _toppingPrice; }
            set { _toppingPrice = value; }
        }
        public override string ToString()
        {
            return $"ToppingType: {ToppingType} ToppingPrice: {ToppingPrice}";
        }

    }

}
