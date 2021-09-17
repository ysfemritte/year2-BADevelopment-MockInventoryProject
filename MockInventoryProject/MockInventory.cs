using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInventoryProject
{
    class MockInventory
    {
        //1. Create Instance Variable - IV (PRIVATE & LOWER CASE) --> Needs to be implemented in 3. Implemented Properties
        private int stock;
        private double price;
        private double gst;

        //2. Auto-Implemented Properties --> No need to validate - String DType
        public string ItemNumber { get; set; }
        public string Description { get; set; }

        //3. Implemented Properties
        public int Stock
        {
            get
            {
                //return IV
                return stock;
            }
            set
            {
                if (value > 0)
                {
                    stock = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Stock", value, "should be greater than 0");
                }
            }
        }// end of stock

        public double Price
        {
            get
            {
                //return IV
                return price;
            }
            set
            {
                if (value > 0.0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price", value, "should be greater than 0");
                }
            }
        }// end of price

        public double GST
        {
            get
            {
                //return IV
                return gst;
            }
            set
            {
                if (value > 0.0 && value <= 12.0)
                {
                    gst = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("GST", value, "should be greater than 0 and less than 12");
                }
            }
        }// end of GST

        //4. Parameterless Constructor

        //5. Parameterised Constructor
        public MockInventory(string _itemNumber, string _description, int _stock, double _price, double _gst)
        {
            //Properties = Parameters
            ItemNumber = _itemNumber;
            Description = _description;
            Stock = _stock;
            Price = _price;
            GST = _gst;
        }

        //6. Methods

        /// <summary>
        /// Purpose: Determine the total value of stock
        /// Argument: None
        /// </summary>
        /// <returns>Returns the total amount as a Double value</returns>
        /// 
        public double Total()
        {
            double result;
            result = stock * price;
            return result;
        }


        /// <summary>
        /// Purpose: Determine the retail value of a single item
        /// Argument: None
        /// </summary>
        /// <returns>Returns the retail value as Double</returns>
        public double Retail()
        {
            double retail;
            retail = Price + (Price * GST);
            return retail;
        }

    } //End of class - NO CODES 
}// End of Namespace
