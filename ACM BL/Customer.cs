using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    /// <summary>
    /// Holds all the information of customers. FirstName, LastName, FullName, EmailAddress, CustomerID
    /// </summary>
    public class Customer : EntityBase
    {
        /// <summary>
        /// default constructor. Calls the parameterized constructor with an initial parameter
        /// </summary>
        public Customer() : this (0)
        {

        }

        /// <summary>
        /// parameterized constructor with id to create customer objects. It creates new address objects too
        /// </summary>
        /// <param name="customerID">carries a unique id for customer</param>
        public Customer( int customerID)
        {
            CustomerID = customerID;
            AddressList = new List<Address>();
        } 

        private string _lastName;

        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public string FirstName { get; set; }

        public string FullName {
            get { return FirstName + " " + LastName; }
        }

        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public int CustomerID { get; private set; }
        public int CustomerType { get; set; }

        /// <summary>
        /// static modifier of customer class
        /// </summary>
        public static int Instances { get; set; }

        /// <summary>
        /// validates customer objects
        /// </summary>
        /// <returns> true or false</returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;

        }
        
    }
}
