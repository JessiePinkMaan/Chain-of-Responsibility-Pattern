using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class NotificationHandler : EventHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == EventType.Notification)
            {
                Console.WriteLine($"Уведомление отработанно!!!!!: {request.Content}");// проверка на уведомление 
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request); // Передаем если не уведомление 
            }
        }
    }
}
