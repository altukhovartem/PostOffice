using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    /*
Интерфейс, который задает класс, который может каким-либо образом обработать почтовый объект.
*/

    interface IMailService
    {
        ISendable ProcessMail(ISendable mail);
    }
}
