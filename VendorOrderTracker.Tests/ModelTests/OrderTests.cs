using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests

  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsOrderName_String()
    {
      string orderName = "Case of donuts.";
      Order newOrder = new Order(orderName);
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "Case of donuts.";
      Order newOrder = new Order(orderName);
      string updatedName = "Case of cakes";
      newOrder.OrderName = updatedName;
      string result = newOrder.OrderName;
      Assert.AreEqual(updatedName, result);
    }
  }
}