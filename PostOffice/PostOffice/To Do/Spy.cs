using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    class Spy: IMailService
    {
        private Logger logger = null;
        private MailMessage mailMessage = null;
        public static readonly String AUSTIN_POWERS = "Austin Powers";

        public Spy(Logger logger)
        {
            this.logger = logger;
        }



        public ISendable ProcessMail(ISendable mail)
        {
            if (mail is MailMessage)
            {
                this.mailMessage = mail as MailMessage;
            }
            else
            {
                throw new Exception("It is not the right ISendable object");
            }



            if (mail.From == AUSTIN_POWERS)
            {
                Console.WriteLine(logger.Log()
            }
        }
    }

    class Logger
    {
        public virtual string Log(Level level, string message)
        {
            string.Format()
        }
    }

    enum Level
    {
        Info,
        Warn,
        Error
    }

}
