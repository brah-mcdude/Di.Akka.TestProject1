using Akka.Actor;
using Akka.DependencyInjection;
using Akka.Event;
using Akka.TestKit;
using Xunit.Abstractions;

namespace TestProject1.Di;

public class DiSpecBase : SpecBase
{
    public DiSpecBase(ITestOutputHelper output) : base(output, DependencyResolverSetup.Create(new ServiceProvider().Provider).And(BootstrapSetup.Create().WithConfig(TestKitBase.DefaultConfig).WithConfigFallback(config)))
    {
        Log.Debug($"in {nameof(DiSpecBase)}");
    }
}
