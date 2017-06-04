using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    /*
    Посылка, содержимое которой можно получить с помощью свойства `Content`
    */


    class MailPackage : AbstractSendable
    {
        private readonly Package content;

        public MailPackage(String from, String to, Package content)
            : base(from, to)
        {
            this.content = content;
        }

        public Package Content
        {
            get { return content; }
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            if (!base.Equals(o)) return false;
            MailPackage that = (MailPackage)o;
            if (!content.Equals(that.content)) return false;
            return true;
        }

    }
}
