using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePrettyHair
{
   public class OrderRepository
    {
        public List<Order>OrderList = new List<Order>();
        public event MailHandler Email;
        public EventArgs e = null;
        public bool inStock;
       

        public delegate void MailHandler(OrderRepository o, EventArgs e);
        public void OrderEvent(OrderRepository o)
        {
   
            if (Email != null)
            {
                Email(o, e);
            }


        }
        public void AddOrderToList(Order o)
        {
            OrderList.Add(o);
            OrderEvent(this);


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
