using Dapper.Contrib.Extensions;
using System.Data;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using ImportacaoXlsApi.Infraestutura.Notification;

namespace InfoRioAPI.Repositories.Generics
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        protected readonly IDbConnection _connection;
        protected readonly INotification _notification;

        public BaseRepository(IDbConnection connection, INotification notification)
        {
            this._notification = notification;           
            this._connection = connection;
            this._connection.Close();
            this._connection.ConnectionString = "User ID=prostgres;Password=root;Host=localhost;Port=5432;Database=ImportacaoXls;Pooling=true;";
            this._connection.Open();
        }

        public void Delete(T entity)
        {
            this._connection.Delete(entity);
        }

        public T Get(int id)
        {
            return this._connection.Get<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return this._connection.GetAll<T>();
        }

        public void Insert(T entity)
        {
            this._connection.Insert<T>(entity);
        }

        public void Update(T entity)
        {
            this._connection.Update<T>(entity);
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
