using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SourceCodePrettyHair;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        CustomerRepository CRepository;
        Customer person1; 
        Customer person2;
        Customer person3;
        OrderRepository ORepository;
        Order order1;
        Order order2;
        Order order3;

        [TestInitialize]
        public void SetUpTest()
        {
            CRepository = new CustomerRepository();
            person1 = new Customer(1);
            person2 = new Customer(2);
            person3 = new Customer(3);
            CRepository.CustomerList.Add(person1);
            CRepository.CustomerList.Add(person2);
            CRepository.CustomerList.Add(person3);

            ORepository = new OrderRepository();
            order1 = new Order(1);
            order2 = new Order(2);
            order3 = new Order(3);
            ORepository.OrderList.Add(order1);
            ORepository.OrderList.Add(order2);
            ORepository.OrderList.Add(order3);
        }
        [TestMethod]
        public void ReadId()
        {
            ProductType p = new ProductType(1, "Test", 12.95, 7);
            Assert.AreEqual(1, p.ID);
        }
        [TestMethod]
        public void ReadDescription()
        {
            ProductType p = new ProductType(1, "Test", 12.95, 7);
            Assert.AreEqual(p.Description, "Test");

        }
        [TestMethod]
        public void ReadPrice()
        {
            ProductType p = new ProductType(1, "Test", 12.95, 7);
            Assert.AreEqual(12.95, p.Price);
        }
        [TestMethod]
        public void ReadAmount()
        {
            ProductType p = new ProductType(1, "Test", 12.95, 7);
            Assert.AreEqual(7, p.Amount);
        }

        [TestMethod]
        public void WithdrawAmount()
        {
            ProductType p = new ProductType(1, "Test", 12.95, 7);
            p.WithdrawAmount(6);
            Assert.AreEqual(1, p.Amount);

        }
        [TestMethod]
        public void ChangePrice()
        {
            ProductType p = new ProductType(1, "Test", 12.95, 7);
            Assert.AreEqual(12.95, p.Price);
            p.Price = 5;
            Assert.AreEqual(5, p.Price);
        }
        [TestMethod]
        public void ChangeDescription()
        {
            ProductType p = new ProductType(1, "Test", 12.95, 7);
            Assert.AreEqual("Test", p.Description);
            p.Description = "Ny streng";
            Assert.AreEqual("Ny streng", p.Description);
        }

        [TestMethod]
        public void CustomerMustHaveAnId()
        {
            Customer person = new Customer(1);
            Assert.AreEqual(person.Id, 1);
        }

        [TestMethod]
        public void FindCustomerById()
        {
            Customer FundetPerson= CRepository.FindCustomerByID(2);

            Assert.AreEqual(FundetPerson,person2);
        }
        [TestMethod]
        public void CreateCustomer()
        {
            Customer jens = new Customer(4, "jens", "vibevej 1");
            CRepository.CustomerList.Add(jens);

            Customer FundetPerson = CRepository.FindCustomerByID(4);

            Assert.AreEqual(FundetPerson, jens);
        }

        [TestMethod]
        public void OrderMustHaveAnId()
        {
            Order ordren = new Order(1);
            Assert.AreEqual(ordren.Id, 1);
        }

        [TestMethod]
        public void FindOrderByID()
        {

            Order FundetOrder = ORepository.FindOrderByID(3);

            Assert.AreEqual(FundetOrder, order3);
        }

        [TestMethod]
        public void CreateAnOrder()
        {
            Order NyOrder = new Order("15-11-2016", "20-11-2016", 4, 10, 4);
            ORepository.OrderList.Add(NyOrder);

            Order FundetOrder = ORepository.FindOrderByID(4);

            Assert.AreEqual(FundetOrder, NyOrder);
        }

        [TestMethod]
        public void RecieveProducts()
        {


        }


    }

}
