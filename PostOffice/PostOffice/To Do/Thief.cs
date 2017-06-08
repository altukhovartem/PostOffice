using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 
// Severity	Code	Description	Project	File	Line	Suppression State
// Error CS0051  Inconsistent accessibility: parameter type 'ISendable' is less accessible than method 'Thief.ProcessMail(ISendable)'	PostOffice C:\source\PostOffice\PostOffice\PostOffice\To Do\Thief.cs	20	Active



namespace PostOffice
{
    public class Thief : IMailService
    {
        private int minPrice = 0;
        private int StolenValue = 0;
        private ISendable currentPackage = null;
             
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
