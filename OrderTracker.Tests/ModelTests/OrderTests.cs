using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
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
    // C:\users\hubba\desktop\OrderTracker.Solution\OrderTracker.Tests\ModelTests\OrderTests.cs(18,28): error CS7036: There is no argument given that corresponds to the required formal parameter 'description' of 'Order.Order(string, string, string, string)' [C: \users\hubba\desktop\OrderTracker.Solution\OrderTracker.Tests\OrderTracker.Test.csproj]



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
      Order newOrder = new Order( "xxx", "description", "xxx", "xxx");

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
      Order newOrder = new Order( "xxx", "xxx", "price", "xxx");

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
      Order newOrder = new Order( "xxx", "xxx", "xxx", "date");

      //Act
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }
  


//     [TestMethod]
//     public void GetAll_ReturnItems_ItemList()
//     {
//       //Arrange
//       string description1 = "Walk the dog";
//       string description2 = "Wash the dishes";
//       Item newItem1 = new Item(description1);
//       Item newItem2 = new Item(description2);
//       List<Item> newList = new List<Item> { newItem1, newItem2};
// //This was the text from the lesson

//       //Act
//       List<Item> result = Item.GetAll();

    

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }
//     [TestMethod]
//     public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);

//       //Act
//       int result = newItem.Id;

//       //Assert
//       Assert.AreEqual(1, result);
//     }
//     
  }
};


