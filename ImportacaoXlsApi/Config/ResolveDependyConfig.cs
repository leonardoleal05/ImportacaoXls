using ImportacaoXlsApi.Infraestutura.Notification;
using ImportacaoXlsApi.Repository;
using ImportacaoXlsApi.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;

namespace ImportacaoXlsApi.Config
{
    public static class ResolveDependyConfig
    {
        public static void ResolveDependency(this IServiceCollection services)
        {
            services.AddScoped<IDbConnection, NpgsqlConnection>();

            services.AddScoped<INotification, Notification>();
            services.AddScoped<ImportacaoRepository>();
            services.AddScoped<ImportacaoService>();
        }
    }
}
