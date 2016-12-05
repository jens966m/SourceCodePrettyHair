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
            System.Console.WriteLine("E-mail Sent");
         
        }
    }
}
