using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec04LibN
{
    public interface ILogger
    {
        void start( string title ); //старт пространства имен / имя пространства
        void log( string message );//вывод сообщения в текущем пространстве / текст
        void stop(); //завершить пространство имен
    }
}
