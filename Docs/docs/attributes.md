# Attributes in xUnit

## Core Testing Attributes

- [FactAttribute](xref:Xunit.FactAttribute): Marks unit tests.
- [TheoryAttribute](xref:Xunit.TheoryAttribute): Defines parameterized tests.
- [InlineDataAttribute](xref:Xunit.InlineDataAttribute): Provides test data.
- [MemberDataAttribute](xref:Xunit.MemberDataAttribute): References external test data.

## Test Lifecycle Attributes

- [BeforeAfterTestAttribute](xref:Xunit.v3.BeforeAfterTestAttribute): Controls test execution order.
- [CollectionBehaviorAttribute](xref:Xunit.CollectionBehaviorAttribute): Manages test isolation.
- [TestPipelineStartupAttribute](xref:Xunit.v3.TestPipelineStartupAttribute): Configures the test pipeline.

## Fixture and Setup Attributes

- [IClassFixture](xref:Xunit.IClassFixture`1): Defines class-level setup.
- [ICollectionFixture](xref:Xunit.ICollectionFixture`1): Manages collection-wide fixtures.
- [AssemblyFixtureAttribute](xref:Xunit.AssemblyFixtureAttribute): Controls assembly-level setup.

## Metadata Attributes

- [TraitAttribute](xref:Xunit.TraitAttribute): Adds descriptive metadata.
- [TestFrameworkAttribute](xref:Xunit.TestFrameworkAttribute): Identifies framework characteristics.
