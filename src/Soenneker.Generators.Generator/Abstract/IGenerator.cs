using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Generators.Generator.Abstract;

/// <summary>
/// An abstract Generator with a cancellable async Generate method.
/// </summary>
public interface IGenerator
{
    /// <summary>
    /// Generates generator for the generator.
    /// </summary>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task that completes when the generate operation is complete.</returns>
    ValueTask Generate(CancellationToken cancellationToken = default);
}
