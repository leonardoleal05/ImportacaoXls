using ImportacaoXlsApi.Infraestutura.Notification;
using ImportacaoXlsApi.Models;
using InfoRioAPI.Repositories.Generics;
using System.Data;

namespace ImportacaoXlsApi.Repository
{
    public class ImportacaoRepository : BaseRepository<Importacao>
    {
        public ImportacaoRepository(IDbConnection connection, INotification notification) : base(connection, notification)
        {
        }
    }
    
}
