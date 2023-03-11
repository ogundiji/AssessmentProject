using AssessmentProject.Entities;
using Cosmonaut;
using Cosmonaut.Extensions.Microsoft.DependencyInjection;
using Microsoft.Azure.Documents.Client;

namespace AssessmentProject.Installers
{
    public static class CosmosInstaller 
    {
        public static IServiceCollection InstallServices(this IServiceCollection services, IConfiguration configuration)
        {
            var cosmosSettings = new CosmosStoreSettings(configuration["ConnectionStrings:DatabaseName"],
                configuration["ConnectionStrings:AccountUri"],
                configuration["ConnectionStrings:AccountKey"],
                new ConnectionPolicy { ConnectionMode = ConnectionMode.Direct, ConnectionProtocol = Protocol.Tcp });

            services.AddCosmosStore<Skills>(cosmosSettings);


            return services;

        }
    }
}
