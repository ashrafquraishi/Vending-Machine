using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingMachineUnitTest
{
    [TestClass]
    public class VendingCartTest
    {
         VendingCart vending = new VendingCart();
        [TestMethod]
        public void MakeInvoice()
        {
            //Arrange
            var SelectedSnack = new List<string>();
            SelectedSnack.Add("Cheetos");
            //Act
            var Invoice = vending.AddToCart(SelectedSnack);
            //Assert
            Assert.AreEqual(2.15, 2.15);
        }
        [TestMethod]
        public void ChargeCustomerIfCustomerEnterMoreThanTheyOwe()
        {
            //Arrange
            double Invoice = 2.15;
            double CustomerMoney =5;
            //Act
            vending.ChargeCustomer(Invoice);
            var ExpectedSubTotal = CustomerMoney - Invoice;
            //Assert
            Assert.AreEqual(ExpectedSubTotal, 2.85);
        }
        [TestMethod]
        public void IfCustomerEnterEqualToWhatTheyOwe()
        {
            //Arrange
            double Invoice = 2.15;
            double CustomerMoney =2.15;
            //Act
            vending.ChargeCustomer(Invoice);
            var ExpectedSubTotal = CustomerMoney - Invoice;
            //Assert
            Assert.AreEqual(ExpectedSubTotal, 0);
        }
        
            [TestMethod]
        public void IfCustomerEnterLessThanWhatTheyOwe()
        {
            //Arrange
            double Invoice = 2.15;
            double CustomerMoney = 2.15;
            //Act
            vending.ChargeCustomer(Invoice);
            var ExpectedSubTotal = CustomerMoney - Invoice;
            //Assert
            Assert.AreEqual(ExpectedSubTotal, 0);
        }
    }

}
