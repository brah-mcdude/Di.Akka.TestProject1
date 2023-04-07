
using Akka.Actor;

namespace TestProject1;

public class TargetActor : ReceiveActor, ILogReceive
{
    public TargetActor(IServiceProvider serviceProvider)
    {
    }
}