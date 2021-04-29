using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// holds information for address. AddressID, AddressType, City, PostalCode, Street, Validate()
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Default Constructor for Address
        /// </summary>
        public Address() { }

        /// <summary>
        /// constructor with ID to create address objects
        /// </summary>
        /// <param name="addressID">carries unique id for Address</param>
        public Address(int addressID) { AddressID = addressID; }

        public int AddressID { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }

        /// <summary>
        /// validates address objects
        /// </summary>
        /// <returns> true or false</returns>
        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
           
            return isValid;

        }
       
    }
}
