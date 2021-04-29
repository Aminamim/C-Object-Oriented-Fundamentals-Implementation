using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// holds information for product. Contains ProductID, ProductName,ProductDescription, CurrentPrice, Validate()
    /// </summary>
    public class Product : EntityBase
    {
        public Product() { }

        /// <summary>
        /// constructor with ID to create product objects
        /// </summary>
        /// <param name="productID">carries unique id for product</param>
        public Product( int productID) { productID = productID; }

        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double? CurrentPrice { get; set; }

        /// <summary>
        /// validates products objects
        /// </summary>
        /// <returns>true or false</returns>
        public  bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null ) isValid = false;
            return isValid;
        }

        /// <summary>
        /// overriding base ToString method to display ProductName
        /// </summary>
        /// <returns>ProductName</returns>
        public override string ToString()
        {
            return ProductName;
        }

    }
}
