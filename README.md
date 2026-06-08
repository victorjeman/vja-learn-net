# vja-learn-net

A learning project by **Victor Jeman** and **Taia Dimitrova** to learn **C#** and **.NET**.

## Goal

Get from beginner to a solid mid level in C# and .NET, with a strong focus on
understanding the language deeply, not just making things work.

The path:

1. **Language first** — understand C# really well (types, classes, interfaces,
   generics, LINQ, async/await, memory, error handling).
2. **Framework basics** — learn enough of .NET to be productive (project layout,
   build/run, packages, common libraries).
3. **Testing focus** — the main emphasis: write tests in C# for a **desktop
   application**, understand the testing fundamentals, and get comfortable with
   them.

## Focus areas

- Deep understanding of the C# language
- Practical, working knowledge of the .NET framework
- Writing and structuring tests for a desktop app
- Reaching a confident mid-level skill across the language and tooling

## Tech

- **Language:** C#
- **Platform:** .NET
- **Target app type:** Desktop application
- **Testing:** C# test frameworks (e.g. xUnit / NUnit / MSTest)

## Project layout

One solution at the root, with the app and its tests split into separate projects
(the idiomatic .NET layout):

```
vja-learn-net/
  VjaLearnNet.sln
  src/VjaLearnNet/            <- the app we grow over time
    Program.cs               <- entry point, wires features together
    Features/                <- one file per capability (e.g. TwoFer.cs)
  tests/VjaLearnNet.Tests/   <- xUnit tests, references the app
    Features/                <- matching tests (e.g. TwoFerTests.cs)
```

## Workflow: exercises as features

We work through the [Exercism C# track](https://exercism.org/tracks/csharp/exercises),
but we **don't treat exercises as throwaway puzzles**. Each one is a *feature* that
slowly builds a real, simple app:

1. Solve / adapt the exercise's code, place it under `src/VjaLearnNet/` (e.g. `Features/`).
2. Adapt the exercise's tests into `tests/VjaLearnNet.Tests/`.
3. Run the tests and the app from the root.

## Getting started

Requirements: **.NET SDK 9** and **VS Code** with the **C#** (or C# Dev Kit) extension.

```bash
# run all tests
dotnet test

# run the app
dotnet run --project src/VjaLearnNet
```

In VS Code, open the repo root; the C# extension picks up `VjaLearnNet.sln` and
gives you a Test Explorer with green/red play buttons next to each `[Fact]`.

## Authors

- Victor Jeman
- Taia Dimitrova
