using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Costumer
    {
        string _costumerName;

        #region
        public Costumer()
        {
            _costumerName = "";
        }
        #endregion

        #region
        public Costumer(string CostumerName)
        {
            _costumerName = CostumerName;
        }
        #endregion

        #region
        public string CostumerName
        {
            get { return _costumerName; }
            set { _costumerName = value; }
        }
        #endregion

        public override string ToString()
        {
            return $"CostumerName: {CostumerName}";
        }
    }
}

   

