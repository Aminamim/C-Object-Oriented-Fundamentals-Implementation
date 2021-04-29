using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// holds information for Order. Contains OrderID, OrderDate, date, Validate()
    /// </summary>
    public class Order
    {

        public Order() : this(0) { }

        /// <summary>
        /// constructor with ID to create order objects
        /// </summary>
        /// <param name="orderID">carries unique id for order</param>
        public Order(int orderID) { 
            orderID = OrderID;
            OrderItems = new List<OrderItem>();
        }
        public int CutomerID { get; set; }
        public int OrderID { get; private set; }

        // public DateTime?  OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAdressID { get; set; }
        public string date { get; set; }

        /// <summary>
        /// validates Order objects
        /// </summary>
        /// <returns>true or false</returns>
        public bool Validate()
        {
            var isValid = true;
            if (date == null) isValid = false;
            return isValid;
        }
    }
}
