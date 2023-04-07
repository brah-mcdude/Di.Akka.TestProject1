using Akka.Actor.Setup;
using Akka.Event;
using Akka.TestKit.Xunit2;
using Xunit.Abstractions;

namespace TestProject1;

public partial class SpecBase : TestKit
{
    protected const string config = @"
akka 
{
    #actor.serialize-messages = on #https://petabridge.com/blog/top-7-akkadotnet-stumbling-blocks/

    #test.filter-leeway = 100ms
    #test.single-expect-default = 100ms
    stdout-loglevel = DEBUG
    loglevel = DEBUG
    log-config-on-start = on
    actor 
    {
        debug 
        {
            receive = on
            unhandled = on
            autoreceive = on
            lifecycle = on
            event-stream = on
        }
    }
}
";

    public SpecBase(ITestOutputHelper output, string? config = config) : base(config, output)
    {
    }

    public SpecBase(ITestOutputHelper output, ActorSystemSetup actorSystemSetup) : base(config: actorSystemSetup, output: output)
    {
        Log.Debug($"in {nameof(SpecBase)}");
    }

    protected virtual void Configure() { }

    protected virtual async Task CreateAsync() => await Task.CompletedTask;

    protected virtual void Connect() { }

    protected virtual async Task Arrange()
    {
        Configure();
        await CreateAsync();
        Connect();
    }

    protected virtual void Act() { }

    protected virtual async Task ActAsync()
    {
        await Task.CompletedTask;
    }

    protected virtual async Task AssertAsync()
    {
        await Task.CompletedTask;
    }

    protected virtual async Task ArrangeActAssertAsync()
    {
        await Arrange();
        await ActAsync();
        Act();
        await AssertAsync();
    }

    protected async Task RunTestAsync()
    {
        await ArrangeActAssertAsync();
    }
}
