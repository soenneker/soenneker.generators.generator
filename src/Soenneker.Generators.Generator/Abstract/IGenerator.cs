using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Generators.Generator.Abstract;

/// <summary>
/// Defines an asynchronous, cancellable generation operation.
/// </summary>
public interface IGenerator
{
    /// <summary>
    /// Produces the implementation-defined generated output.
    /// </summary>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task that completes when generation finishes.</returns>
    ValueTask Generate(CancellationToken cancellationToken = default);
}
