using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// repository for Address class. Will interact with data store. Contains Retreive and Save
    /// </summary>
    class AddressRepository
    {
        /// <summary>
        /// retreives an address from data store with the requested id. Dummy.
        /// </summary>
        /// <param name="addressID">requested id</param>
        /// <returns>address with corresponding id</returns>
        public Address Retreive(int addressID)
        {
            // creating new instance of Address class. passing the requested id
            Address address = new Address(addressID);

            //database codes should be written here to get data from database

            // temporary dummy data setting
            if (addressID == 1)
            {
                address.AddressType = 1;
                address.City = "Bandar";
                address.PostalCode = "1410";
                address.Street = "Wilson Road";
                
            }
            else if (addressID == 2)
            {
                address.AddressType = 1;
                address.City = "Bandar";
                address.PostalCode = "1410";
                address.Street = "SSH Road";
            }

            return address;
        }

        /// <summary>
        /// retreives the list of address for the requested customerID
        /// </summary>
        /// <param name="customerID">requested customer ID</param>
        /// <returns>Address list</returns>
        public IEnumerable<Address> RetreiveByCustomerID(int customerID)
        {
            //Creating address list
            var addressList = new List<Address>();

            //temporary dummy code for data store 
            Address address = new Address(1)
            {
                AddressType = 1,
                City = "Bandar",
                PostalCode = "1410",
                Street = "Wilson Road"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                City = "Bandar",
                PostalCode = "1410",
                Street = "SSH Road"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// saves changes in database. Dummy.
        /// </summary>
        /// <param name="address"></param>
        /// <returns>true or false</returns>
        public bool Save(Address address)
        {
            //database code for saving changes in database

            return true;
        }
    }
}
