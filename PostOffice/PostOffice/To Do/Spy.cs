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
            string msgForLogger = string.Empty;
            if (mail is MailMessage)
            {
                this.mailMessage = mail as MailMessage;
                if (mail.From == AUSTIN_POWERS)
                {
                    msgForLogger = string.Format("Detected target mail correspondence: from {0} to {1} {2}", mailMessage.From, mailMessage.To, mailMessage.Message);
                    logger.Log(Level.Warn, msgForLogger);
                }
                else
                {
                    msgForLogger = string.Format("Usual correspondence: from {0} to {1}", mailMessage.From, mailMessage.To);
                    logger.Log(Level.Info, msgForLogger);
                }
            }
            else
            {
                throw new Exception("It is not the right ISendable object");
            }
            return mail;
        }
    }

    class Logger
    {
        private List<string> logFile = new List<string>();
        public virtual void Log(Level level, string message)
        {
            logFile.Add(string.Format("{0}: {1}", level, message));
        }
    }

    enum Level
    {
        Info,
        Warn,
        Error
    }

}
