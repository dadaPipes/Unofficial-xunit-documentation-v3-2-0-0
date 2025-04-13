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
