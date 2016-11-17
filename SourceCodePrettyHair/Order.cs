using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePrettyHair
{
    public class Order
    {
        public string OrderDate;
        public string DeleveriDate;
        public int ProductTypeId;
        public int Quantity;
        public int Id;

        public Order(int id)
        {
            Id = id;

        }
        public Order(string orderDate, string deleveriDate, int productTypeId, int quantity, int id)
        {
            OrderDate = orderDate;
            DeleveriDate = deleveriDate;
            ProductTypeId = productTypeId;
            Quantity = quantity;
            Id = id;

        }







    }
}
