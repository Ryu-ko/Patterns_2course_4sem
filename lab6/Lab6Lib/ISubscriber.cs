using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Lib
{
    public interface ISubscriber //для подписчика
    {
        void update(string eventname); //вызов при наступлении события
    }
}
