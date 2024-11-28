using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class Request //сам класс запроса
    {
        public EventType Type { get; set; }
        public string Content { get; set; }

        public Request(EventType type, string content)
        {
            Type = type;
            Content = content;
        }
    }

    // типы событий
    public enum EventType
    {
        Error,
        Notification,
    }
}
