using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    
    class Order
    {
        #region
        private string _name;
        double _taxPcT;
        int _DeliveryCosts;
        Pizza p;
        Costumer c;
        #endregion

        #region
        public Order(Pizza pizza, Costumer costumer)
        {
            p = pizza;
            c = costumer;
            TaxPcT = 25;
            DeliveryCosts = 40;
        }
        #endregion

        #region
        public double TaxPcT
        {
            get { return _taxPcT; }
            set { _taxPcT = value; }
        }
        #endregion

        #region
        public int DeliveryCosts
        {
            get { return _DeliveryCosts; }
            set { _DeliveryCosts = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion


        #region
        public override string ToString()
        {
            return $"Pizza: {p.Name} Costumer: {c.CostumerName} Total: {CalculateTotalPrice()}";
        }
        #endregion
        public double CalculateTotalPrice()
        {
            return p.PizzaPrice * (1 + TaxPcT / 100) + DeliveryCosts;
        }

    }



}
