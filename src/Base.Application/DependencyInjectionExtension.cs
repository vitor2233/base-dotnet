using Base.Application.UseCases.Register;
using Base.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Base.Application;
public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterBaseUseCase, RegisterBaseUseCase>();
    }
}