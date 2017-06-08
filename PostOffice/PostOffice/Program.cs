using PostOffice.To_Do;
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
            AbstractSendable mail2 = new MailMessage("Austin Powers", "Dr. Evil", "Dr. Evil - Lox!");

            //IMailService[] party = new ThirdPartyMailService[2]
            //{
            //    new ThirdPartyMailService(),
            //    new ThirdPartyMailService()
            //};

            //UntrustworthyMailWorker untrustworthyMailWorker = new UntrustworthyMailWorker(party);
            //untrustworthyMailWorker.ProcessMail(mail);
            //Console.WriteLine(untrustworthyMailWorker.RealMailServiceProp.ToString());


            //Spy spy = new Spy(new Logger());
            //spy.ProcessMail(mail);
            //spy.ProcessMail(mail2);

            Inspector insp = new Inspector();
            insp.ProcessMail(mail);
 
        }
    }
}
