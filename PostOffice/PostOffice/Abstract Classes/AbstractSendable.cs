using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{

    /*
    Абстрактный класс,который позволяет абстрагировать логику хранения
    источника и получателя письма в соответствующих полях класса.
    */


    class AbstractSendable : ISendable
    {
        protected readonly String from;
        protected readonly String to;

        public AbstractSendable(String from, String to)
        {
            this.from = from;
            this.to = to;
        }

        public String From
        {
            get { return from; }
        }

        public String To
        {
            get { return to; }
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            AbstractSendable that = (AbstractSendable)o;
            if (!from.Equals(that.from)) return false;
            if (!to.Equals(that.to)) return false;
            return true;
        }

    }
}
