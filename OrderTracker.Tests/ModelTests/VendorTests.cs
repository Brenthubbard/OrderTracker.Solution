using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetNameReturnsName_String()
    {
      //Arrange
      string name= "Name";
      Vendor newVendor = new Vendor(name, "xxx");
      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Description";
      Vendor newVendor = new Vendor("xxx", description);
      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string vendor= "Test Vendor";
      Vendor newVendor = new Vendor(vendor, "xxx");

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string vendor1 = "Vendor1";
      string vendor2 = "Vendor2";
      Vendor newVendor1 = new Vendor(vendor1, "xxx");
      Vendor newVendor2 = new Vendor(vendor2, "xxx");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      //Arrange
      string vendor1 = "Vendor1";
      string vendor2 = "Vendor";
      Vendor newvendor1 = new Vendor(vendor1, "xxx");
      Vendor newvendor2 = new Vendor(vendor2, "xxx");

      //Act
      Vendor result = Vendor.Find(1);

      //Assert
      Assert.AreEqual(newvendor1, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithvendor_OrderList()
    {
      //Arrange
      string description = "xxx";
      Order newOrder = new Order(description, "xxx", "xxx", "xxx");
      List<Order> newList = new List<Order> { newOrder };
      string name= "xxx";
      Vendor newVendor = new Vendor(name, "xxx");
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
