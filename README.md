[![](https://img.shields.io/nuget/v/soenneker.generators.generator.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.generators.generator/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.generators.generator/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.generators.generator/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.generators.generator.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.generators.generator/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.generators.generator/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.generators.generator/actions/workflows/codeql.yml)

# Soenneker.Generators.Generator

A minimal contract and abstract base class for asynchronous, cancellable generation jobs.

## Install

```bash
dotnet add package Soenneker.Generators.Generator
```

## Implement a generator

```csharp
using Soenneker.Generators.Generator;

public sealed class ClientGenerator : Generator
{
    public override async ValueTask Generate(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        await WriteClientSources(cancellationToken);
    }
}
```

Depend on `IGenerator` when the caller does not need the concrete implementation:

```csharp
using Soenneker.Generators.Generator.Abstract;

public sealed class GenerationCommand(IGenerator generator)
{
    public ValueTask Run(CancellationToken cancellationToken) =>
        generator.Generate(cancellationToken);
}
```

## Behavior

- `IGenerator` defines one `Generate` operation. `Generator` is an optional base class with no additional behavior.
- Cancellation is cooperative: implementations must observe or pass the token to their asynchronous work.
- The contract does not define output locations, concurrency, idempotency, scheduling, logging, retries, or dependency-injection registration. Those choices belong to the implementation and its host.
- Exceptions and cancellation propagate to the caller.
