using Soenneker.Tests.HostedUnit;

namespace Soenneker.Generators.Generator.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class GeneratorTests : HostedUnitTest
{
    public GeneratorTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
