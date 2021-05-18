using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test2", "test3", "test4");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsOrderName_String()
    {
      //Arrange
      string orderName = "Order One";
      Order newOrder = new Order(orderName, "xxx", "xxx", "xxx");

      //Act
      string result = newOrder.OrderName;

      //Assert
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetDescription_ReturnADescription_String()
    {
      //Arrange
      string description = "description";
      Order newOrder = new Order("xxx", "description", "xxx", "xxx");

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetPrice_ReturnPrice_String()
    {
      //Arrange
      string price = "price";
      Order newOrder = new Order("xxx", "xxx", "price", "xxx");

      //Act
      string result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void SetDate_ReturnDate_String()
    {
      //Arrange
      string date = "date";
      Order newOrder = new Order("xxx", "xxx", "xxx", "date");

      //Act
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }



    [TestMethod]
    public void GetAll_ReturnOrders_OrderList()
    {
      //Arrange
      string orderName = "Order";
      string description = "six cases";
      string price = "9 million";
      string date = "5/13/2030";
      Order order1 = new Order(orderName, "xxx", "xxx", "xxx");
      Order order2 = new Order("xxx", description, "xxx", "xxx");
      Order order3 = new Order("xxx", "xxx", price, "xxx");
      Order order4 = new Order("xxx", "xxx", "xxx", date);
      List<Order> newList = new List<Order> { order1, order2, order3, order4 };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string orderName = "Order";
      Order newOrder = new Order(orderName, "xxx", "xxx", "xxx");

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

  }
};


