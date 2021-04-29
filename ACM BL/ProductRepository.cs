using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// repository for product class. Will interact with data store. Contains Retreive and Save
    /// </summary>
    public class ProductRepository : EntityBase
    {
        /// <summary>
        /// retreives a product from data store with the requested id. Dummy.
        /// </summary>
        /// <param name="productID">requested id</param>
        /// <returns>product with corresponding id</returns>
        public Product Retreive(int productID)
        {
            Product product = new Product(productID);

            //database codes should be written here to get data from database

            // temporary dummy data setting
            if (productID == 1)
            {
                product.ProductName = "Bag";
                product.CurrentPrice = 57.7;
                product.ProductDescription = "Women Handbag";
            }
            if (productID == 2)
            {
                product.ProductName = "Shoe";
                product.CurrentPrice = 70;
                product.ProductDescription = "Men's Shoe";
            }

            return product;
        }

        /// <summary>
        /// saves changes in database. Dummy.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>true or false</returns>
        public bool Save(Product product)
        {
            //database code for saving changes in database

            bool success;

            if (product.HasChanged)
            {
                success = true;

                if (product.IsNew)
                {
                  success = true; 

                //   if (product.IsValid)
                //  {
                //      success = true;
                //  }
                //  else { success = false; }

                }else { success = false; }
            }else { success = false; }

            return success;
        }


    }
}
