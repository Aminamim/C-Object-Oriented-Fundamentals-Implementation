using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// holds information for orderItem. contains OrderItemID, ProductID, PurchasePrice, Quantity, Validate()
    /// </summary>
    public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemID) { OrderItemID = orderItemID; }

        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// validates OrderItem objects
        /// </summary>
        /// <returns>true or false</returns>
        public bool Validate()
        {
            var isValid = true;
            if (ProductID <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null ) isValid = false;
            return isValid;
        }
    }
}
