using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractSendable mail = new MailMessage("Vasya", "Vanya", "Lalka!");
            AbstractSendable package = new MailPackage("Vanya", "Vasya", new Package("Dota2.exe", 0));

            IMailService[] party = new ThirdPartyMailService[2]
            {
                new ThirdPartyMailService(),
                new ThirdPartyMailService()
            };

            IMailService untrustworthyMailWorker = new UntrustworthyMailWorker(party);
            untrustworthyMailWorker.ProcessMail(mail);


        }
    }
}
