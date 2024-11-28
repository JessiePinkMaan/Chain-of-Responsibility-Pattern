namespace Chain_of_Responsibility_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // сами запросы
            var errorRequest = new Request(EventType.Error, "Ошибка: срок захвата 3 дня истек ( попробуйте снова!!");
            var notificationRequest = new Request(EventType.Notification, "Уведомление: Ваш заказ был спрятан!!!!!");
           

            // Создаем обработчиков
            var errorHandler = new ErrorHandler();
            var notificationHandler = new NotificationHandler();
    ;

            // Строим цепочку
            errorHandler.SetNextHandler(notificationHandler);
  

         
            Console.WriteLine("Обработка ошибка:");
            errorHandler.HandleRequest(errorRequest);

            Console.WriteLine("\nОбработка уведомления:");
            errorHandler.HandleRequest(notificationRequest);


        }
    }
}