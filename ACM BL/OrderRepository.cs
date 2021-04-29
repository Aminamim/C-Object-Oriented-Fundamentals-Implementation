using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// repository for order class. Will interact with data store. Contains Retreive and Save
    /// </summary>
    public class OrderRepository
    {
        public Order Retreive(int orderID)
        {
            Order order = new Order (orderID);

            //database codes should be written here to get data from database

            // temporary dummy data setting
            if (orderID == 1)
            {
                order.date = "today";
            }
            
            return order;
        }

        /// <summary>
        /// saves changes in database. Dummy.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>true or false</returns>
        public bool Save(Order order)
        {
            //database code for saving changes in database

            return true;
        }

    }
}
