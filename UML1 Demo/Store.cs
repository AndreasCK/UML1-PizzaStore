using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Store
    {
        public void Start()
        {
            
            Pizza p1 = new Pizza("Margherita", "Cheese", 72);
            Pizza p2 = new Pizza("Vesuvio", "Ham", 78);
            Pizza p3 = new Pizza("Felix", "Pepperoni", 78);

            Costumer c1 = new Costumer("Anders");
            Costumer c2 = new Costumer("Peter");
            Costumer c3 = new Costumer("Johan");

            Order Order1 = new Order(p2,c1);
            Order Order2 = new Order(p3,c3);
            Order Order3 = new Order(p1,c2);

            Console.WriteLine(Order1);
            Console.WriteLine();
            Console.WriteLine(Order2);
            Console.WriteLine();
            Console.WriteLine(Order3);
            
        }
    }
}
