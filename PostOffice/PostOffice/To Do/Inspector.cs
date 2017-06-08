using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.To_Do
{
    public class Inspector : IMailService
    {
        public static readonly String WEAPONS = "weapons";
        public static readonly String BANNED_SUBSTANCE = "banned substance";


        public ISendable ProcessMail(ISendable mail)
        {
            if (mail is Package)
            {
                Package currentPackage = mail as Package;
                if (currentPackage.Content == WEAPONS || currentPackage.Content == BANNED_SUBSTANCE)
                {
                    throw new IllegalPackageException();
                }
                else if (currentPackage.Content.Contains("stones"))
                {
                    throw new StolenPackageException();
                }
            }
            return mail;
        }
    }

    class IllegalPackageException: Exception
    {
        public override string Message
        {
            get
            {
                return "Illegal Package";
            }
        }
    }

    class StolenPackageException : Exception
    {
        public override string Message
        {
            get
            {
                return "Stolen Package";
            }
        }
    }



}
