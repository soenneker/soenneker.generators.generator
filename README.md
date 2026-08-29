[![](https://img.shields.io/nuget/v/soenneker.generators.generator.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.generators.generator/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.generators.generator/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.generators.generator/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.generators.generator.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.generators.generator/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.generators.generator/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.generators.generator/actions/workflows/codeql.yml)

# Soenneker.Generators.Generator

An abstract Generator with a cancellable async Generate method.

## Install

```bash
dotnet add package Soenneker.Generators.Generator
```

## Quick start

```csharp
using Soenneker.Generators.Generator.Abstract;

IGenerator generator = /* resolve from DI */;
await generator.Generate(default);
```

Generates generator for the generator.

## What you get

- `IGenerator` — An abstract Generator with a cancellable async Generate method.
