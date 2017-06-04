using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    /*
Класс, в котором скрыта логика настоящей почты
*/

    class RealMailService
    {
        public ISendable ProcessMail(ISendable mail)
        {
            return mail;
        }
    }
}
