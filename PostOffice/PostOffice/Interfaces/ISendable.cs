using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
         /*
     Интерфейс: сущность, которую можно отправить по почте.
     У такой сущности можно получить от кого и кому направляется письмо.
     */


    interface ISendable
    {
        String From { get; }
        String To { get; }
    }
}
