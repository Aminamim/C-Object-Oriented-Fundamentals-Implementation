using System;
using ACM_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACL.BLTest
{
    
    [TestClass]
    public class CustomerTest
    {
        /// <summary>
        /// checks if the fullname is valid
        /// </summary>
        [TestMethod]
        public void IsFullNameValid()
        {
            //arrange
            Customer custmer = new Customer();
            custmer.FirstName = "Wahida";
            custmer.LastName = "Mina";
            string expected = "Wahida Mina";

            //act
            string actual = custmer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
            
        }


        /// <summary>
        /// checks if first name is empty
        /// </summary>
        [TestMethod]
        public void IsFirstNameEmpty()
        {
            //arrange
            Customer custmer = new Customer();
            
            custmer.LastName = "Mina";
            string expected = "Mina";

            //act
            string actual = custmer.FullName;

            //assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// checks if customer instance is incrementing while creating new instances of customer class
        /// </summary>
        [TestMethod]
        public void IsStaticInstanceWorking()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Anan";
            Customer.Instances ++;

            var c2 = new Customer();
            c1.FirstName = "Mahim";
            Customer.Instances++;

            int expected = 2;

            //act
            
            //assert
            Assert.AreEqual(expected, Customer.Instances);

        }

        /// <summary>
        /// checks if customer instance is incrementing while creating new instances of customer class
        /// </summary>
        [TestMethod]
        public void IsValidateWorking()
        {
            //arrange
            Customer customer = new Customer();
            customer.FirstName = "Sadia";
            customer.LastName = " ";
            customer.EmailAddress = "sadia@afrin";
            var expected = true;

            //act
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
