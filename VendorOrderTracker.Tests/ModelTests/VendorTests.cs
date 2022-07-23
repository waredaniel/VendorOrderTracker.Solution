using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Test

{
  [TestClass]
  public class VendorTests: IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test info");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "Test vendor";
      string vendorInfo = "test1";
      Vendor newVendor = new Vendor(name, vendorInfo);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test vendor";
      string vendorInfo = "test1";
      Vendor newVendor = new Vendor(name, vendorInfo);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName01 = "Supermarket";
      string vendorName02 = "Restaurant";
      string vendorInfo1 = "test1";
      string vendorInfo2 = "test2";
      Vendor newVendor1 = new Vendor(vendorName01, vendorInfo1);
      Vendor newVendor2 = new Vendor(vendorName02, vendorInfo2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
      string vendorName01 = "Supermarket";
      string vendorName02 = "Restaurant";
      string vendorInfo1 = "test1";
      string vendorInfo2 = "test2";
      Vendor newVendor1 = new Vendor(vendorName01, vendorInfo1);
      Vendor newVendor2 = new Vendor(vendorName02, vendorInfo2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

  }

}