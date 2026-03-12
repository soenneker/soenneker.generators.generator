using Soenneker.Generators.Generator.Abstract;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Generators.Generator;

/// <inheritdoc cref="IGenerator"/>
public abstract class Generator : IGenerator
{
    public abstract ValueTask Generate(CancellationToken cancellationToken = default);
}