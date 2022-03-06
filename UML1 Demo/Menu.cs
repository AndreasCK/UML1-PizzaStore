using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Menu
    {
        string _menuTypes;


        public Menu()
        {
            _menuTypes = "";
        }

        public Menu(string MenuTypes)
        {
            _menuTypes = MenuTypes;
        }

        public string MenuTypes
        {
            get { return _menuTypes; }
            set { _menuTypes = value; }
        }
        public override string ToString()
        {
            return $"MenuTypes: {MenuTypes}";
        }
    }
}
