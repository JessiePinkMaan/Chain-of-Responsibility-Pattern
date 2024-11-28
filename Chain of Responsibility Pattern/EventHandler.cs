using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
 
    public abstract class EventHandler
    {
        protected EventHandler _nextHandler; //следующий обработчик 

        
        public void SetNextHandler(EventHandler nextHandler) //устанавливаем следующего обработчика 
        {
            _nextHandler = nextHandler;
        }

       
        public abstract void HandleRequest(Request request);
    }

}
