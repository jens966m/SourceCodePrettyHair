using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePrettyHair
{
    public class Email

    {


        public void Subscribe(OrderRepository o)
        {
            o.Email += new OrderRepository.MailHandler(MailSent);
        }
        private void MailSent(OrderRepository o, EventArgs e)
        {
            if (o.inStock == true)
            {
                System.Console.WriteLine("E-mail Sent");
               
            }
            
            else
            {
                System.Console.WriteLine("E-mail Sent. Not in stock");
            }
        }
    }
}
