using Microsoft.Extensions.DependencyInjection;
using QMeal.Application.Services.Authentication;

namespace QMeal.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
