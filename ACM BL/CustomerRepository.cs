using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// repository for customer class. Will interact with data store. Contains Retreive and Save
    /// </summary>
    public class CustomerRepository
    {
        /// <summary>
        /// constructor that includes creating address repository instance. makes the collaborative relation between customerRepository and addressRepository
        /// </summary>
        public CustomerRepository()
        {
            //creating new address repository
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// retreives a customer from data store with the requested id. Dummy.
        /// </summary>
        /// <param name="customerID">requested id</param>
        /// <returns>customer with corresponding id</returns>
        public Customer Retreive(int customerID)
        {
            // creating new instance of Customer class. passing the requested id
            Customer customer = new Customer(customerID);
            
            //database codes should be written here to get data from database

            // temporary dummy data setting
            if(customerID == 1)
            {
                customer.EmailAddress = "Sadia@afrin";
                customer.FirstName = "Sadia";
                //populating RetreieveByCustomerID and receiving coresponding list of address
                customer.AddressList = addressRepository.RetreiveByCustomerID(customerID).ToList();
            }
            if (customerID == 2)
            {
                customer.EmailAddress = "Shaiara@rafah";
                customer.FirstName = "Rafah";
                customer.AddressList = addressRepository.RetreiveByCustomerID(customerID).ToList();
            }

            return customer;
        }

         /// <summary>
        /// saves changes in database. Dummy.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>true or false</returns>
        public bool Save ( Customer customer)
        {
            //database code for saving changes in database

            return true;
        }
    }
}
