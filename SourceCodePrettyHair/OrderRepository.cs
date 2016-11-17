using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePrettyHair
{
   public class OrderRepository
    {
        public List<Order> OrderList;
        public OrderRepository()
        {
            OrderList = new List<Order>();
        }

        public Order FindOrderByID(int id)
        {

            foreach (Order ordren in OrderList)
            {
                if (ordren.Id == id)
                {
                    return ordren;
                }
            }
            throw new Exception("Ordren ikke fundet");
        }
    }
}
