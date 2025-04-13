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
