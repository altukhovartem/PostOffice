using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    public class Thief : IMailService
    {
        private int minPrice = 0;
        private int StolenValue = 0;
             
        public Thief(int minPrice)
        {
            this.minPrice = minPrice;
        }

        public ISendable ProcessMail(ISendable mail)
        {
            if (mail is Package) // ?
            {
                Package currentPackege = mail as Package;
                if (currentPackege.Price >= minPrice)
                {
                    string fakeContent = string.Format("stones instead of {}", currentPackege);
                    Package fakePackage = new Package(fakeContent, 0);
                    StolenValue += currentPackege.Price;
                    return (ISendable)fakePackage;
                }
            }
            return mail;

        }
    }
}
