using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodePrettyHair;

namespace PrettyHairUI
{
    class ConsoleFunctions
    {
        public ProductType DummyProduct;
        public List<ProductType> ProductTypeList;
        public OrderRepository orderRepo;
        public Email e;
        int productTypeId;
        int quantity;

        public ConsoleFunctions()
        {
            ProductTypeList = new List<ProductType>();
            orderRepo = new OrderRepository();
            e = new Email();
            e.Subscribe(orderRepo);

            for (int i = 0; i <= 2; i++)
            {
                int Pid = i;
                string description = "Dummy" + i;
                double price = 100;
                int amount = 10;
                DummyProduct = new ProductType(Pid, description, price, amount);

                ProductTypeList.Add(DummyProduct);

            }
         
        }

        public void ShowProductList()
        {
            foreach (ProductType Pid in ProductTypeList)
            {

                Console.WriteLine(Pid.ID + " " + Pid.Amount + " " + Pid.Description + " " + Pid.Price);
            }
        }

        public void CreateOrderByConsole()
        {

            Console.WriteLine("Opret order");

            Console.Write("indsæt id:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("indsæt order dato:");
            string orderDate = Console.ReadLine();

            Console.Write("indsæt afleverings dato:");
            string deleveriDate = Console.ReadLine();

            Console.Write("indsæt produkt id:");
            productTypeId = int.Parse(Console.ReadLine());

            Console.Write("indsæt mængde:");
            quantity = int.Parse(Console.ReadLine());


            Order newOrder = new Order(orderDate, deleveriDate, productTypeId, quantity, id);

            bool inStock = false;
            foreach (ProductType produktet in ProductTypeList)
            {
                if (produktet.ID == productTypeId && inStock != true)
                {
                    orderRepo.inStock = produktet.InStock(quantity);
                    DummyProduct = produktet;
                }
            }

            orderRepo.AddOrderToList(newOrder);

        }
        public void ProcessOrder()
        {
            if (orderRepo.inStock == true)
            {
                Console.WriteLine("Press a key to process order");
                Console.ReadKey();
                DummyProduct.WithdrawAmount(quantity);
                ProductTypeList[productTypeId] = DummyProduct;
                Console.WriteLine("Orden er sendt");

            }
            else
            {
                int missingAmount = quantity - ProductTypeList[productTypeId].Amount;
                Console.WriteLine("Der mangler " + missingAmount + " varer, for at ordren kan sendes");
            }
        }





    }

}
