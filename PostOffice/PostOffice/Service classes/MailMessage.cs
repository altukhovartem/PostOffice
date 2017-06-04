using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    /*
    Письмо, у которого есть текст, который можно получить с помощью свойства `Message`
    */


    class MailMessage : AbstractSendable
    {
        private readonly String message;

        public MailMessage(String from, String to, String message)
            : base(from, to)
        {
            this.message = message;
        }

        public String Message
        {
            get { return message; }
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            if (!base.Equals(o)) return false;
            MailMessage that = (MailMessage)o;
            if (message != null ? !message.Equals(that.message) : that.message != null) return false;
            return true;
        }

    }
}
