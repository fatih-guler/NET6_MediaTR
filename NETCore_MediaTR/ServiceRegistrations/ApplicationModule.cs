namespace NETCore_MediaTR.ServiceRegistrations
{
    public static class ApplicationModule
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblyContaining<Program>();
            });
            return services;
        }
    }
}
