
namespace TestProject1.Di;

abstract public class ServiceProviderBase
{
    protected abstract IServiceProvider CreateProvider();

    private IServiceProvider? provider;

    public IServiceProvider? Provider
    {
        get => provider ??= CreateProvider();
    }
}