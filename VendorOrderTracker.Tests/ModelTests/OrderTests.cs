using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOrder_Order()
    {
      Order newOrder = new Order("name", "description", 1, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsOrderName_String()
    {
      string orderName = "Case of donuts.";
      string orderDescription = "test";
      int orderCost = 1;
      string orderDate = "date";
      Order newOrder = new Order(orderName, orderDescription, orderCost, orderDate);
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "Case of donuts.";
      string orderDescription = "test";
      int orderCost = 1;
      string orderDate = "date";
      Order newOrder = new Order(orderName, orderDescription, orderCost, orderDate);
      string updatedName = "Case of cakes";
      newOrder.OrderName = updatedName;
      string result = newOrder.OrderName;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetAll_ReturnEmptyList_OrderList()
    {
    List<Order> newList = new List<Order> { };
    List<Order> result = Order.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description01 = "Case of donuts";
      string description02 = "Case of cakes";
      string orderDescription = "test";
      int orderCost = 1;
      string orderDate = "date";
      Order newOrder1 = new Order(description01, orderDescription, orderCost, orderDate);
      Order newOrder2 = new Order(description02, orderDescription, orderCost, orderDate);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}