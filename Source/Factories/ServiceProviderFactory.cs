using Microsoft.Extensions.DependencyInjection;
using Common;

namespace Source.Factories
{
    public static class ServiceProviderFactory
    {
        private static ServiceProvider CreateServiceProvider()
        {
            // configure and register services in container
            return new ServiceCollection()
                .AddMyAppServices()
                .BuildServiceProvider();
        }

        public static IEnumerable<T> GetRequiredService<T>()
        {
            // get services and scope only the dependencies registered for this container
            using var scope = CreateServiceProvider().CreateScope();

            return scope.ServiceProvider.GetServices<T>();
        }
    }
}