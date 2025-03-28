using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Generators.Generator.Tests;

[Collection("Collection")]
public class GeneratorTests : FixturedUnitTest
{
    public GeneratorTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
