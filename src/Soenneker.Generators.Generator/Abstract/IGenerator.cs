using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Generators.Generator.Abstract;

/// <summary>
/// An abstract Generator with a cancellable async Generate method.
/// </summary>
public interface IGenerator
{
    /// <summary>
    /// Executes the generate operation.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    ValueTask Generate(CancellationToken cancellationToken = default);
}