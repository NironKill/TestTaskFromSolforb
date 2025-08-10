using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Application.Common.Behaviors;
using Warehouse.Application.Repositories.Implementations;
using Warehouse.Application.Repositories.Interfaces;

namespace Warehouse.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

            services.AddScoped<IAdmissionDocumentRepository, AdmissionDocumentRepository>();
            services.AddScoped<IAdmissionResourceRepository, AdmissionResourceRepository>();
            services.AddScoped<IBalanceRepository, BalanceRepository>();
            services.AddScoped<IShippingDocumentRepository, ShippingDocumentRepository>();
            services.AddScoped<IShippingResourceRepository, ShippingResourceRepository>();

            return services;
        }
    }
}
