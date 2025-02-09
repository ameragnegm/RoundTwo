using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Product
    {
        public Product( string name , int price , int quantity) 
        {
           Name = name;
           Price = price;
           StockQuantity = quantity;
        }
        public string Name { get; set; }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("The price is invalid");
                }
            }
        }
      
        private int stockquantity;
        public int StockQuantity
        {
            get
            {
                return stockquantity;
            }

             private set
            {
               
                    stockquantity = value;
            }

        }

        public bool Isavailable
        {
            get
            {
                if (StockQuantity > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
   
        
        public void UpdateStock ( int quantitychanges) {
            int newquantity = StockQuantity + quantitychanges;
            if (newquantity > 0)
            {
                StockQuantity = newquantity;
            } else
            {
                Console.Write("Stock quantity cannot be negative.");
            }
        }
    }
}
        
