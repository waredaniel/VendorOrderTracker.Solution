using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    private static List<Order> _instances = new List<Order> { };
    
    public Order(string orderName)
    {
      OrderName = orderName;
      _instances.Add(this);

    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}