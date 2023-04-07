using Microsoft.Extensions.DependencyInjection;

namespace TestProject1.Di;

public class ServiceProvider : ServiceProviderBase
{
    protected override IServiceProvider CreateProvider()
    {
        Console.WriteLine($"{nameof(ServiceProvider)}: {GetHashCode()}");

        var services = new ServiceCollection();

        return services.BuildServiceProvider();
    }
}
