# Release Notes for v3 2.0.0 [2025 March 1]

Today, we’re shipping one new release:

**xUnit.net Core Framework v3 2.0.0**
It’s been 3 weeks since the release of [1.1.0 RTM](https://xunit.net/releases/v3/1.1.0).

As always, we’d like to thank all the users who contributed to the success of xUnit.net through usage, feedback, and code contributions.

These release notes are a list of changes from `1.1.0` to `2.0.0`.

> [!IMPORTANT]
> This release contains breaking changes as indicated by the major version bump. Binary compatibility with `1.x.y` packages is not guaranteed, and extensibility projects should verify whether these breaking changes affect them as they may be required to issue new versions.

## Target Framework and Dependency Updates

- The minimum version of [.NET](https://dotnet.microsoft.com/en-us/download) has been bumped up from .NET 6 to .NET 8 as Microsoft discontinued support for .NET 6 in November 2024. The [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework) minimum version remains at `4.7.2`.

- The minimum version of [Microsoft.Testing.Platform](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-intro?tabs=dotnetcli) has been upgraded to `1.6.2`.

- The minimum version of [System.Collections.Immutable](https://www.nuget.org/packages/System.Collections.Immutable/) has been downgraded to `6.0.0`.

- The minimum version of [System.Memory](https://www.nuget.org/packages/System.Memory/) has been downgraded to `4.5.5`.

## Core Framework

### New property

[Fact](xref:Xunit.FactAttribute) has added a new property: [Type](xref:Xunit.FactAttribute.SkipExceptions)

```csharp
/// <summary>
/// Gets exceptions that, when thrown, will cause the test to be skipped rather than failed.
/// </summary>
/// <remarks>
/// The skip reason will be the exception's message.
/// </remarks>
public Type[]? SkipExceptions { get; set; }
```

This property allows developers to indicate which exception types, when thrown, should be considered a skipped test rather than a failed test. The expected common usage here will be for exceptions like `NotSupportedException` (TODO: Where does NotSupportedException exist in the api docs ?) which indicate that the test cannot run in the current execution environment. For more information, see the linked [issue](https://github.com/xunit/xunit/issues/3101).

#### The following breaking changes were caused by this change

- Adding [IFactAttribute.SkipExceptions](xref:Xunit.v3.IFactAttribute.SkipExceptions).
  
- Adding [FactAttribute.SkipExceptions](xref:Xunit.FactAttribute.SkipExceptions).
  
- Adding [IXunitTestCase.SkipExceptions](xref:Xunit.v3.IXunitTestCase.SkipExceptions).
  
- Adding skipExceptions parameter to the XunitTestCase [constructor](xref:Xunit.v3.XunitTestCase).
  
- Adding skipExceptions parameter to the XunitDelayEnumeratedTheoryTestCase [constructor](xref:Xunit.v3.XunitDelayEnumeratedTheoryTestCase).
  
- Adding SkipExceptions to the return tuple from [TestIntrospectionHelper.GetTestCaseDetails](xref:Xunit.v3.TestIntrospectionHelper.GetTestCaseDetails(Xunit.Sdk.ITestFrameworkDiscoveryOptions,Xunit.v3.IXunitTestMethod,Xunit.v3.IFactAttribute,System.Object[],System.Nullable{System.Int32},System.String)) and [.GetTestCaseDetailsForTheoryDataRow](xref:Xunit.v3.TestIntrospectionHelper.GetTestCaseDetailsForTheoryDataRow(Xunit.Sdk.ITestFrameworkDiscoveryOptions,Xunit.v3.IXunitTestMethod,Xunit.v3.ITheoryAttribute,Xunit.ITheoryDataRow,System.Object[])).
  
- Updated logic in [XunitTestRunnerBaseContext.GetSkipReason](xref:Xunit.v3.XunitTestRunnerBaseContext`1.GetSkipReason(System.Exception)) to support the skip exception types.

### Improved Test Cancellation in v3 with In-Process Runner

We have updated an old design for cancellation, wherein test execution cancellation could only be requested in response to a message being sent by the execution engine.  
This design dates back to v1/v2 wherein the cross`-AppDomain` communication created limitations in communication between the runner and the execution engine.  
The primary downside is that the developer would have to wait for a message from the execution engine before the cancellation request could take place.  
If the system was stuck waiting for long-running tests, that meant that the cancellation request would be delayed until at least one of the long-running tests finished (success or failure).

With the v3 in-process runner design, we can now use [CancellationToken](xref:Xunit.TestContext.CancellationToken), in concert with the new `TestContext.Current.CancellationToken` to immediately propagate cancellation requests without waiting for an execution engine message.  
In practice, this means that long-running tests will cancel immediately when requested (assuming the unit test is using the cancellation token from the test context for long-running operations). [xunit/xunit#3122](https://github.com/xunit/xunit/issues/3122)

#### The following breaking changes were caused by this change

- [InProcessController](xref:Xunit.v3.InProcessFrontController) methods [Find](xref:Xunit.v3.InProcessFrontController.Find(Xunit.Sdk.IMessageSink,Xunit.Sdk.ITestFrameworkDiscoveryOptions,System.Func{Xunit.Sdk.ITestCase,System.Boolean},System.Threading.CancellationTokenSource,System.Type[],System.Func{Xunit.Sdk.ITestCase,System.Boolean,System.Threading.Tasks.ValueTask{System.Boolean}})), [FindAndRun](xref:Xunit.v3.InProcessFrontController.FindAndRun(Xunit.Sdk.IMessageSink,Xunit.Sdk.ITestFrameworkDiscoveryOptions,Xunit.Sdk.ITestFrameworkExecutionOptions,System.Func{Xunit.Sdk.ITestCase,System.Boolean},System.Threading.CancellationTokenSource,System.Type[])), and [Run](xref:Xunit.v3.InProcessFrontController.Run(Xunit.Sdk.IMessageSink,Xunit.Sdk.ITestFrameworkExecutionOptions,System.Collections.Generic.IReadOnlyCollection{Xunit.Sdk.ITestCase},System.Threading.CancellationTokenSource)) methods now all take CancellationTokenSource.

- `ITestFrameworkExecution.RunTestCases` now takes an optional CancellationToken. TestFrameworkExecutor’s implementation of RunTestsCases will propagate this the cancellation token, for extensibility authors who derive from this base class.

- The `TestAssemblyRunnerContext` constructor now takes a required CancellationToken, and rather than manufacturing a new CancellationTokenSource (as it did in 1.x.y), it will instead wrap the cancellation token. Developers overriding the CancellationTokenSource property should be careful not to discard the original token source, since this would also discard the original token.

- The constructors for `XunitTestAssemblyRunnerBaseContext` and `XunitTestAssemblyRunnerContext` also require a CancellationToken, since they derive from `TestAssemblyRunnerContext`.

- `XunitTestAssemblyRunner.Run` now takes a required CancellationToken, so that it can construct the context correctly.

- The `ProjectAssemblyRunner` constructor now takes a required CancellationTokenSource. (xunit.v3.runner.inproc.console)

- `ConsoleRunner` has become IDisposable in order to dispose of the cancellation token source that it creates. (xunit.v3.runner.inproc.console)

### Retrieving attachments when generating execution messages has been updated to improve extensibility

#### The following breaking changes were caused by this change

- [TestRunnerBase<TContext, TTest>](xref:Xunit.v3.TestRunnerBase`2) has a new extensibility point, [GetAttachments(TContext)](xref:Xunit.v3.TestRunnerBase`2.GetAttachments(`0)), which is used to retrieve the attachments for the test finished message. By default, this returns `null`.

- [TestRunnerBase<TContext, TTest>.OnTestFinished(TContext, decimal, string, string[]?, IReadOnlyDictionary<string, TestAttachment>?)](xref:Xunit.v3.TestRunnerBase`2.OnTestFinished(`0,System.Decimal,System.String,System.String[],System.Collections.Generic.IReadOnlyDictionary{System.String,Xunit.Sdk.TestAttachment})) has an additional parameter, `IReadOnlyDictionary<string, TestAttachment>? attachments`

- [TestRunnerBase<TContext, TTest>.Run(TContext)](xref:Xunit.v3.TestRunnerBase`2.Run(`0)) has been updated to call [GetAttachments(TContext)](xref:Xunit.v3.TestRunnerBase`2.GetAttachments(`0)) and pass the value to [OnTestFinished(TContext, decimal, string, string[]?, IReadOnlyDictionary<string, TestAttachment>?)](xref:Xunit.v3.TestRunnerBase`2.OnTestFinished(`0,System.Decimal,System.String,System.String[],System.Collections.Generic.IReadOnlyDictionary{System.String,Xunit.Sdk.TestAttachment})). This call is made immediately after the call to `GetTestOutput` and `GetWarnings` after the test has finished executing.

Original: "is now where TestContext.Current.Attachments is called." Thought: `Current` and `Attachments` are two different methods

- [XunitTestRunnerBase.GetAttachments(TContext)](xref:Xunit.v3.XunitTestRunnerBase`2.GetAttachments(`0)) is now where [TestContext.Current](xref:Xunit.TestContext.Current) and [TestContext.Attachments](xref:Xunit.TestContext.Attachments*) is called.  
Previously, this call lived in [TestRunnerBase<TContext, TTest>.OnTestFinished(TContext, decimal, string, string[]?, IReadOnlyDictionary<string, TestAttachment>?)](xref:Xunit.v3.TestRunnerBase`2.OnTestFinished(`0,System.Decimal,System.String,System.String[],System.Collections.Generic.IReadOnlyDictionary{System.String,Xunit.Sdk.TestAttachment})), so the result of this shift is that extensibility code that relied on [TestRunnerBase<TContext, TTest>](xref:Xunit.v3.TestRunnerBase`2) to get attachments from the test context will need to be updated to override [GetAttachments(TContext)](xref:Xunit.v3.XunitTestRunnerBase`2.GetAttachments(`0)) just like [XunitTestRunnerBase<TContext, TTest>](xref:Xunit.v3.XunitTestRunnerBase`2). (This also allows extensibility authors to choose a non-TestContext based source for attachments.)

### Bugs

- We have fixed an issue where there was ambiguity with overloads of [Record.ExceptionAsync](xref:Xunit.Record.Exception(System.Action)) that took both [Task](xref:System.Threading.Tasks.Task) and [ValueTask](xref:System.Threading.Tasks.ValueTask) overloads. We have removed the [ValueTask](xref:System.Threading.Tasks.ValueTask) overloads. If you were previously calling a [ValueTask](xref:System.Threading.Tasks.ValueTask) overload, you can call AsTask() on the [ValueTask](xref:System.Threading.Tasks.ValueTask) instance to turn it into a [Task](xref:System.Threading.Tasks.Task). (We had previous fixed the ambiguity in async assertions, like [Assert.ThrowsAsync](xref:Xunit.Assert.ThrowsAsync(System.Type,System.Func{System.Threading.Tasks.Task})), but [Record.ExceptionAsync](xref:Xunit.Record.Exception(System.Action)) was overlooked when the original change was implemented.)  
  [xunit/xunit#2808](https://github.com/xunit/xunit/issues/2808)

- We unintentionally reordered the calling order of [BeforeAfterTestAttribute](xref:Xunit.v3.BeforeAfterTestAttribute) attributes.  
  Assembly attributes are called first, then test collection attributes, then test class attributes, then test method attributes. This restores the ordering behavior from v2.  
  [xunit/xunit#3180](https://github.com/xunit/xunit/issues/3180)

## Assertion Library

### Improved Assert.Equal Display for String Comparison Failures in Containers

We have updated the assertion failure display for [Assert.Equal](xref:Xunit.Assert.Equal(System.String,System.String)) when there is a failure comparing strings inside of containers.  
[xunit/xunit#3126](https://github.com/xunit/xunit/issues/3126)

```csharp
[Fact]
public void TestMethod()
{
    var expected = new[]
    {
        @"C:\Program Files (x86)\Common Files\Extremely Long Path Name\VST2",
    };

    var actual = new[]
    {
        @"C:\Program Files (x86)\Common Files\Extremely Long Path Name\VST3"
    };

    Assert.Equal(expected, actual);
}
```

Previously when strings were not equal inside of containers, those strings were printed with the standard “first n characters” formatting, which made it harder for users to understand what the failed comparison was (especially with long strings):

```shell
TestClass.TestMethod [FAIL]
  Assert.Equal() Failure: Collections differ
             ↓ (pos 0)
  Expected: ["C:\\Program Files (x86)\\Common Files\\Extremely L"···]
  Actual:   ["C:\\Program Files (x86)\\Common Files\\Extremely L"···]
             ↑ (pos 0)
```

Now in 2.0.0, this prints a more useful message which highlights the string comparsion, using the index pointers for string failure points and using a single index notation on which item in the collection caused the failure:

```shell
TestClass.TestMethod [FAIL]
  Assert.Equal() Failure: Collections differ at index 0
                                                                    ↓ (pos 64)
  Expected: ···"s (x86)\\Common Files\\Extremely Long Path Name\\VST2"
  Actual:   ···"s (x86)\\Common Files\\Extremely Long Path Name\\VST3"
                                                                    ↑ (pos 64)
```

### IAssertEqualityComparer\<T\> Introduced with Single Method for Assert.Equal Comparison Enhancements

We have added [IAssertEqualityComparer\<T\>](xref:Xunit.Sdk.IAssertEqualityComparer`1), which is implemented by [AssertEqualityComparer\<T\>](xref:Xunit.Sdk.AssertEqualityComparer`1). This new interface has a single method attached to it:

```csharp
AssertEqualityResult Equals(T? x, CollectionTracker? xTracker, T? y, CollectionTracker? yTracker);
```

This replaces the older version of this method on [AssertEqualityComparer\<T\>](xref:Xunit.Sdk.AssertEqualityComparer`1), which returned bool. The new method returns [AssertEqualityResult](xref:Xunit.Sdk.AssertEqualityResult), which is defined as:

```csharp
public class AssertEqualityResult : IEquatable<AssertEqualityResult>
{
    /// <summary>
    /// Returns <c>true</c> if the values were equal; <c>false</c>, otherwise.
    /// </summary>
    public bool Equal { get; }

    /// <summary>
    /// Returns the exception that caused the failure, if it was based on an exception.
    /// </summary>
    public Exception? Exception { get; }

    /// <summary>
    /// Returns the comparer result for any inner comparison that caused this result
    /// to fail; returns <c>null</c> if there was no inner comparison.
    /// </summary>
    /// <remarks>
    /// If this value is set, then it generally indicates that this comparison was a
    /// failed collection comparison, and the inner result indicates the specific
    /// item comparison that caused the failure.
    /// </remarks>
    public AssertEqualityResult? InnerResult { get; }

    /// <summary>
    /// Returns the index of the mismatch for the <c>X</c> value, if the comparison
    /// failed on a specific index.
    /// </summary>
    public int? MismatchIndexX { get; }

    /// <summary>
    /// Returns the index of the mismatch for the <c>Y</c> value, if the comparison
    /// failed on a specific index.
    /// </summary>
    public int? MismatchIndexY { get; }

    /// <summary>
    /// The left-hand value in the comparison
    /// </summary>
    public object? X { get; }

    /// <summary>
    /// The right-hand value in the comparison
    /// </summary>
    public object? Y { get; }
}
```

This new data structure captures information about the comparison results, including the ability to dive into inner comparison results. This allows for richer potential output messages for assertion failures.

Additionally, code that previous relied on the class [AssertEqualityComparer\<T\>](xref:Xunit.Sdk.AssertEqualityComparer`1) (which is internal) can now rely on both first and third party implementations of [IAssertEqualityComparer\<T\>](xref:Xunit.Sdk.IAssertEqualityComparer`1) (in particular, `Assert.Equal` and `Assert.NotEqual`), which allows third parties to write comparers which can participate in the richer result messages.

### StringAssertEqualityComparer Introduced for Centralized String Comparison Logic in Assert Methods

We have added StringAssertEqualityComparer which centralizes the previous string comparison logic that was an implementation detail of `Assert.Equal` and `Assert.NotEqual` with string (and char-base span) overloads. The primary entry point are two static functions:

```csharp
public static AssertEqualityResult Equivalent(
    string? expected,
    string? actual,
    bool ignoreCase = false,
    bool ignoreLineEndingDifferences = false,
    bool ignoreWhiteSpaceDifferences = false,
    bool ignoreAllWhiteSpace = false);

public static AssertEqualityResult Equivalent(
    ReadOnlySpan<char> expected,
    ReadOnlySpan<char> actual,
    bool ignoreCase = false,
    bool ignoreLineEndingDifferences = false,
    bool ignoreWhiteSpaceDifferences = false,
    bool ignoreAllWhiteSpace = false);
```

You’ll note that we’ve opted to call these functions `Equivalent` rather than `Equal` given their ability to customize their comparisons with respect to case, line endings, and white space.  
These flags are equivalent to the `string` (and `char`-based span) overloads of `Assert.Equal` and `Assert.NotEqual`.

### A new factory function overload for [EqualException](xref:Xunit.Sdk.EqualException) has been added for string mismatches with a custom header

```csharp
public static EqualException ForMismatchedStringsWithHeader(
    string? expected,
    string? actual,
    int expectedIndex,
    int actualIndex,
    string header);
```

### The primary comparison function on [CollectionTracker](xref:Xunit.Sdk.CollectionTracker) was also updated with the new data structure

This method:

```csharp
public static bool AreCollectionsEqual(
    CollectionTracker? x,
    CollectionTracker? y,
    IEqualityComparer itemComparer,
    bool isDefaultItemComparer,
    out int? mismatchedIndex);
```

has been replaced by this method:

```csharp
public static AssertEqualityResult AreCollectionsEqual(
    CollectionTracker? x,
    CollectionTracker? y,
    IEqualityComparer itemComparer,
    bool isDefaultItemComparer);
```

In addition to returning [AssertEqualityResult](xref:Xunit.Sdk.AssertEqualityResult) rather than `bool`, there is another subtle but important change. Previously this function would not catch exceptions when third party comparers would throw, but rather relied on ensuring mismatchedIndex was set appropriately when those exceptions were propagated. The new code catches all exceptions, and returns [AssertEqualityResult](xref:Xunit.Sdk.AssertEqualityResult) objects where `.Exception` has the captured exception.

The old method was marked with [Obsolete] and will be removed in `3.0.0`.

### New AssertEquivalenceComparer Types Added for Enhanced Equivalent Value Comparisons

Two new types, [AssertEquivalenceComparer](xref:Xunit.AssertEquivalenceComparer) (implementing IEqualityComparer) and [AssertEquivalenceComparer\<T\>](xref:Xunit.AssertEquivalenceComparer`1) (implementing IEqualityComparer<\T>) have been added. These call [Assert.Equivalent(object?, object?, bool)](xref:Xunit.Assert.Equivalent(System.Object,System.Object,System.Boolean)) on the passed values, including throwing `EqualivalentException` when the comparison fails rather than returning false.  
The constructor for these types allow you to provide the value for strict that would normally be passed to [Assert.Equivalent(object?, object?, bool)](xref:Xunit.Assert.Equivalent(System.Object,System.Object,System.Boolean)).  
[xunit/xunit#3186](https://github.com/xunit/xunit/discussions/3186)

The primary intended usage for this is in response to a request for an overload of [Assert.Equivalent(object?, object?, bool)](xref:Xunit.Assert.Equivalent(System.Object,System.Object,System.Boolean)) for collections which required the collection values be in the exact order. When considering potential ways to satisfy this request, these new types were provided which can be passed to `Assert.Equal` (which guarantees identical order of collections) and passing this type for the item comparer:

```csharp
public sealed record class Foo(int Id, string Name)
{
    public bool Equals(Foo? other) => Id == other?.Id;

    public override int GetHashCode() => Id.GetHashCode();
}

public class UnitTest
{
    [Fact]
    public void Collection_of_foo_should_be_ordered_equivalent()
    {
        var fooOrg = new Foo(1, "foo");
        var fooUpdated = fooOrg with { Name = "bar" };

        var actual = new[] { fooUpdated, fooOrg };
        var expected = new[] { fooOrg, fooUpdated };

        Assert.Equal(expected, actual, new AssertEquivalenceComparer<Foo>(strict: false));
    }
}
```

The failure for this looks like:

```shell
UnitTest.Collection_of_foo_should_be_ordered_equivalent [FAIL]
  Assert.Equal() Failure: Exception thrown during comparison
             ↓ (pos 0)
  Expected: [Foo { Id = 1, Name = foo }, Foo { Id = 1, Name = bar }]
  Actual:   [Foo { Id = 1, Name = bar }, Foo { Id = 1, Name = foo }]
             ↑ (pos 0)
  ---- Assert.Equivalent() Failure: Mismatched value on member 'Name'
  Expected: "foo"
  Actual:   "bar"
```

## Project Templates

### Enhanced Project Templates Enable Target Framework Overrides with --framework Option

We have updated the projects templates (shipped in `xunit.v3.templates`) to allow overriden target frameworks via `--framework` (or `-f`):

- `xunit3` allows `net8.0` (default), `net9.0`, `net472`, `net48`, and `net481`.

- `xunit3-extension` allows `netstandard2.0` (default), `net8.0`, `net9.0`, `net472`, `net48`, and `net481`.

The target framework override is also available when using the new templates inside Visual Studio and JetBrains Rider.
