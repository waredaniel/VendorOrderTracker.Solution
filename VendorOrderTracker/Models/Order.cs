using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    
    public Order(string orderName)
    {
      OrderName = orderName;
      
    }
  }

}