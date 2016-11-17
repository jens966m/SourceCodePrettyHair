using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePrettyHair
{
    public class CustomerRepository
    {
      public  List<Customer> CustomerList;


        public CustomerRepository()
        {
            CustomerList = new List<Customer>();
        }

        public Customer FindCustomerByID(int id)
        {
            foreach (Customer person in CustomerList)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            throw new Exception("Person ikke fundet");

        }
    }



    

}
