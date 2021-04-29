using System;
using System.Collections.Generic;
using ACM_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACL.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        
        [TestMethod]
        public void IsRetrieveWorking()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1){
                EmailAddress = "Sadia@afrin",
                FirstName = "Sadia"
            };

            //act
            var actual = customerRepository.Retreive(1);

            //assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
        }


        [TestMethod]
        public void IsRetrievingAddressWorking()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Sadia@afrin",
                FirstName = "Sadia",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                         City = "Bandar",
                        PostalCode = "1410",
                        Street = "Wilson Road"
                    },
                    new Address()
                    {
                        AddressType = 1,
                        City = "Bandar",
                        PostalCode = "1410",
                        Street = "SSH Road"
                    }
                }
            };

            //act
            var actual = customerRepository.Retreive(1);

            //assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType );
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City );
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode );
                Assert.AreEqual(expected.AddressList[i].Street, actual.AddressList[i].Street );
            }
        }

    }
}
