using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    // Обработчик для обработки ошибок
    public class ErrorHandler : EventHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == EventType.Error) // проверяем на ошибку если это она то обрабатываем
            {
                Console.WriteLine($"Ошибка переработана!!!!!!: {request.Content}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request); // скидываем на другой  обработчик если не ошибка
            }
        }
    }
}
