using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace KTMS.Application.Common
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Register MediatR handlers from Application layer
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            // Ako ćeš koristiti FluentValidation, možeš dodati i ovo:
            // services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
