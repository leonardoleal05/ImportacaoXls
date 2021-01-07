using ImportacaoXlsApi.Infraestutura.Notification;
using System.Collections.Generic;

namespace ImportacaoXlsApi.Service
{
    public class GenericService
    {
        private readonly INotification _notification;

        public GenericService(INotification notification)
        {
            this._notification = notification;
        }
        protected void Add(string message)
        {
            this._notification.Add(message);
        }

        protected bool IsNotifications()
        {
            return this._notification.IsNotifications();
        }

        protected List<string> ListAll()
        {
            return this._notification.ListAll();
        }

    }
}
