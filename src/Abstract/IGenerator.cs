using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Generators.Generator.Abstract;

/// <summary>
/// An abstract Generator with a cancellable async Generate method.
/// </summary>
public interface IGenerator
{
    ValueTask Generate(CancellationToken cancellationToken = default);
}