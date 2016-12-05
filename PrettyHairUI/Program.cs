using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodePrettyHair;

namespace PrettyHairUI
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

        }


        public void Run()
        {
            OrderRepository orderRepo = new OrderRepository();
            Order newOrder = new Order(57);
            Email e = new Email();
            e.Subscribe(orderRepo);

            orderRepo.AddOrderToList(newOrder);


            Console.ReadLine();
        }

    }
}
