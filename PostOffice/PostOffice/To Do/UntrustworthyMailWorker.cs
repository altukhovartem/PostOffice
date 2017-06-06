using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    class UntrustworthyMailWorker : IMailService
    {
        private AbstractSendable sendableObj = null;
        private IMailService[] arrayOfThirdPartyMailServices = null;
        private IMailService realMailService = null;

        public IMailService RealMailServiceProp
        {
            get { return realMailService; }
        }

        public UntrustworthyMailWorker(IMailService[] arrayOfThirdPartyMailServices)
        {
            this.arrayOfThirdPartyMailServices = arrayOfThirdPartyMailServices;
            this.sendableObj = null;
            this.realMailService = new RealMailService();
        }

        public ISendable ProcessMail(ISendable mail)
        {
            ISendable sendableObj = mail; 
            foreach (IMailService service in arrayOfThirdPartyMailServices)
            {
                sendableObj = service.ProcessMail(sendableObj);
            }
            return realMailService.ProcessMail(sendableObj);
        }
    }

    class ThirdPartyMailService : IMailService
    {
        public ISendable ProcessMail(ISendable mail)
        {
            return mail;
        }
    }
}
