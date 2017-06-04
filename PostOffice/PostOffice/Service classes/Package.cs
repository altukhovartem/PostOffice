using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    /*
    Класс, который задает посылку. У посылки есть текстовое описание содержимого и целочисленная ценность.
    */

    class Package
    {
        private readonly String content;
        private readonly int price;

        public Package(String content, int price)
        {
            this.content = content;
            this.price = price;
        }

        public String Content
        {
            get { return content; }
        }

        public int Price
        {
            get { return price; }
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            Package aPackage = (Package)o;
            if (price != aPackage.price) return false;
            if (!content.Equals(aPackage.content)) return false;
            return true;
        }

    }
}
