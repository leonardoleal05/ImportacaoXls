using System.Collections.Generic;

namespace ImportacaoXlsApi.Infraestutura.Notification
{
    public interface INotification
    {
        bool IsNotifications();
        void Add(string message);
        List<string> ListAll();
    }
}
