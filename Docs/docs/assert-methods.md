# Assert methods

## BooleanAsserts

- [False(Bool)](xref:Xunit.Assert.False(System.Boolean))  
  Verifies that the condition is false.

- [False(Bool, String?)](xref:Xunit.Assert.False(System.Boolean,System.String))  
  Verifies that the condition is false.

- [False(Bool?)](xref:Xunit.Assert.False(System.Nullable{System.Boolean}))  
  Verifies that the condition is false.

- [False(Bool?, String?)](xref:Xunit.Assert.False(System.Nullable{System.Boolean},System.String))  
  Verifies that the condition is false.

- [True(Bool)](xref:Xunit.Assert.True(System.Boolean))  
  Verifies that an expression is true.

- [True(Bool, String?)](xref:Xunit.Assert.True(System.Boolean,System.String))  
  Verifies that an expression is true.

- [True(Bool?)](xref:Xunit.Assert.True(System.Nullable{System.Boolean}))  
  Verifies that an expression is true.

- [True(Bool?, String?)](xref:Xunit.Assert.True(System.Nullable{System.Boolean},System.String))  
  Verifies that an expression is true.

## AsyncCollectionAsserts

- [All\<T\>(IEnumerable\<T\>, Action\\<T\>)](xref:Xunit.Assert.All``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0,System.Int32}))  
  Verifies that all items in the collection pass when executed against action

- [All\<T\>(IEnumerable\<T\>, Action<T, int>)](xref:Xunit.Assert.All``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0,System.Int32}))  
  Verifies that all items in the collection pass when executed against action.  
  The item index is provided to the action, in addition to the item.

- [AllAsync\<T\>(IEnumerable\<T\>, Func\<T, Task\>)](xref:Xunit.Assert.AllAsync``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Threading.Tasks.Task}))  
  Verifies that all items in the collection pass when executed against action.

- [AllAsync\<T\>(IEnumerable\<T\>, Func\<T, int, Task\>)](xref:Xunit.Assert.AllAsync``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Int32,System.Threading.Tasks.Task}))  
  Verifies that all items in the collection pass when executed against action.  
  The item index is provided to the action, in addition to the item.

- [Collection\<T\>(IEnumerable\<T\>, params Action\<T\>[])](xref:Xunit.Assert.Collection``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0}[]))  
  Verifies that a collection contains exactly a given number of elements,  
  which meet the criteria provided by the element inspectors.

- [CollectionAsync\<T\>(IEnumerable\<T\>, params Func\<T, Task\>[])](xref:Xunit.Assert.CollectionAsync``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Threading.Tasks.Task}[]))  
  Verifies that a collection contains exactly a given number of elements,  
  which meet the criteria provided by the element inspectors.

- [Contains\<T\>(T, IEnumerable\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Generic.IEnumerable{``0}))  
  Verifies that a collection contains a given object.

- [Contains\<T\>(T, IEnumerable\<T\>, IEqualityComparer\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that a collection contains a given object, using an equality comparer.

- [Contains\<T\>(IEnumerable\<T\>, Predicate\<T\>)](xref:Xunit.Assert.Contains``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0}))  
  Verifies that a collection contains a given object.

- [Distinct\<T\>(IEnumerable\<T\>, IEqualityComparer\<T\>)](xref:Xunit.Assert.Distinct``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that a collection contains each object only once.

- [DoesNotContain\<T\>(T, IEnumerable\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Generic.IEnumerable{``0}))  
  Verifies that a collection does not contain a given object.

- [DoesNotContain\<T\>(T, IEnumerable\<T\>, IEqualityComparer\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that a collection does not contain a given object, using an equality comparer.

- [DoesNotContain\<T\>(IEnumerable\<T\>, Predicate\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0}))  
  Verifies that a collection does not contain a given object.

- [Empty(IEnumerable)](xref:Xunit.Assert.Empty(System.Collections.IEnumerable))  
  Verifies that a collection is empty.

- [Equal\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?)](xref:Xunit.Assert.Equal``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0}))  
  Verifies that two sequences are equivalent, using a default comparer.

- [Equal\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, IEqualityComparer\<T\>)](xref:Xunit.Assert.Equal``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that two sequences are equivalent, using a custom equatable comparer.

- [Equal\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, Func<T, T, bool>)](xref:Xunit.Assert.Equal``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,System.Boolean}))  
  Verifies that two collections are equal, using a comparer function against items in the two collections.

- [NotEmpty(IEnumerable)](xref:Xunit.Assert.NotEmpty(System.Collections.IEnumerable))  
  Verifies that a collection is not empty.

- [NotEqual\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?)](xref:Xunit.Assert.NotEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0}))  
  Verifies that two sequences are not equivalent, using a default comparer.

- [NotEqual\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, IEqualityComparer\<T\>)](xref:Xunit.Assert.NotEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that two sequences are not equivalent, using a custom equality comparer.

- [NotEqual\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, Func<T, T, bool>)](xref:Xunit.Assert.NotEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,System.Boolean}))  
  Verifies that two collections are not equal, using a comparer function against items in the two collections.

- [Single(IEnumerable)](xref:Xunit.Assert.Single(System.Collections.IEnumerable))  
  Verifies that the given collection contains only a single element of the given type.

- [Single\<T\>(IEnumerable\<T\>, Predicate\<T\>)](xref:Xunit.Assert.Single``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0}))  
  Verifies that the given collection contains only a single element of the given type which matches the given predicate.  
  The collection may or may not contain other values which do not match the given predicate.

## CollectionAsserts

- [All\<T\>(IEnumerable\<T\>, Action<T\>)](xref:Xunit.Assert.All``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0}))  
  Verifies that all items in the collection pass when executed against action.

- [All\<T\>(IEnumerable\<T\>, Action\<T, int\>)](xref:Xunit.Assert.All``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0,System.Int32}))  
  Verifies that all items in the collection pass when executed against action.  
  The item index is provided to the action, in addition to the item.

- [AllAsync\<T\>(IEnumerable\<T\>, Func\<T, Task\>)](xref:Xunit.Assert.AllAsync``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Threading.Tasks.Task}))  
  Verifies that all items in the collection pass when executed against action.

- [AllAsync\<T\>(IEnumerable\<T\>, Func\<T, int, Task\>)](xref:Xunit.Assert.AllAsync``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Int32,System.Threading.Tasks.Task}))  
  Verifies that all items in the collection pass when executed against action.  
  The item index is provided to the action, in addition to the item.

- [Collection\<T\>(IEnumerable\<T\>, params Action\<T\>[])](xref:Xunit.Assert.Collection``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0}[]))  
  Verifies that a collection contains exactly a given number of elements,  
  which meet the criteria provided by the element inspectors.

- [CollectionAsync\<T\>(IEnumerable\<T\>, params Func\<T, Task\>[])](xref:Xunit.Assert.CollectionAsync``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Threading.Tasks.Task}[]))  
  Verifies that a collection contains exactly a given number of elements,  
  which meetthe criteria provided by the element inspectors.

- [Contains\<T\>(T, IEnumerable\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Generic.IEnumerable{``0}))  
  Verifies that a collection contains a given object.

- [Contains\<T\>(T, IEnumerable\<T\>, IEqualityComparer\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that a collection contains a given object, using an equality comparer.

- [Contains\<T\>(IEnumerable\<T\>, Predicate\<T\>)](xref:Xunit.Assert.Contains``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0}))  
  Verifies that a collection contains a given object.

- [Distinct\<T\>(IEnumerable\<T\>, IEqualityComparer\<T\>)](xref:Xunit.Assert.Distinct``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that a collection contains each object only once.

- [Distinct\<T\>(IEnumerable\<T\>)](xref:Xunit.Assert.Distinct``1(System.Collections.Generic.IEnumerable{``0}))  
  Verifies that a collection contains each object only once.

- [DoesNotContain\<T\>(T, IEnumerable\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Generic.IEnumerable{``0}))  
  Verifies that a collection does not contain a given object.

- [DoesNotContain\<T\>(T, IEnumerable\<T\>, IEqualityComparer\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that a collection does not contain a given object, using an equality comparer.

- [DoesNotContain\<T\>(IEnumerable\<T\>, Predicate\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0}))  
  Verifies that a collection does not contain a given object.

- [Empty(IEnumerable))](xref:Xunit.Assert.Empty(System.Collections.IEnumerable))  
  Verifies that a collection is empty.

- [Equal\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?)](xref:Xunit.Assert.Equal``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0}))  
  Verifies that two sequences are equivalent, using a default comparer.

- [Equal\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, IEqualityComparer\<T\>)](xref:Xunit.Assert.Equal``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that two sequences are equivalent, using a custom equatable comparer.

- [Equal\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, Func\<T, T, bool\>)](xref:Xunit.Assert.Equal``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,System.Boolean}))  
  Verifies that two collections are equal, using a comparer function against items in the two collections.

- [NotEmpty(IEnumerable)](xref:Xunit.Assert.NotEmpty(System.Collections.IEnumerable))  
  Verifies that a collection is not empty.

- [NotEqual\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?)](xref:Xunit.Assert.NotEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0}))  
  Verifies that two sequences are not equivalent, using a default comparer.

- [NotEqual\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, IEqualityComparer\<T\>)](xref:Xunit.Assert.NotEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that two sequences are not equivalent, using a custom equality comparer.

- [NotEqual\<T\>(IEnumerable\<T\>?, IEnumerable\<T\>?, Func<T, T, bool>)](xref:Xunit.Assert.NotEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,System.Boolean}))  
  Verifies that two collections are not equal, using a comparer function against items in the two collections.

- [Single(IEnumerable)](xref:Xunit.Assert.Single(System.Collections.IEnumerable))  
Verifies that the given collection contains only a single element of the given type.

- [Single(IEnumerable, object?)](xref:Xunit.Assert.Single(System.Collections.IEnumerable,System.Object))  
Verifies that the given collection contains only a single element of the given value.  
The collection may or may not contain other values.

- [Single<T>(IEnumerable\<T\>)](xref:Xunit.Assert.Single``1(System.Collections.Generic.IEnumerable{``0}))  
Verifies that the given collection contains only a single element of the given type.

- [Single<T>(IEnumerable\<T\>, Predicate\<T\>)](xref:Xunit.Assert.Single``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0}))  
Verifies that the given collection contains only a single element of the given type which matches the given predicate.  
The collection may or may not contain other values which do not match the given predicate.

## DictionaryAsserts
  
- [Contains<TKey, TValue>(TKey, ConcurrentDictionary<TKey, TValue>))](xref:Xunit.Assert.Contains``2(``0,System.Collections.Concurrent.ConcurrentDictionary{``0,``1}))  
  Verifies that a dictionary contains a given key.
  
- [Contains<TKey, TValue>(TKey, Dictionary<TKey, TValue>)](xref:Xunit.Assert.Contains``2(``0,System.Collections.Generic.Dictionary{``0,``1}))  
  Verifies that a dictionary contains a given key.

- [Contains<TKey, TValue>(TKey, IDictionary<TKey, TValue>)](xref:Xunit.Assert.Contains``2(``0,System.Collections.Generic.IDictionary{``0,``1}))  
  Verifies that a dictionary contains a given key.
  
- [Contains<TKey, TValue>(TKey, IReadOnlyDictionary<TKey, TValue>)](xref:Xunit.Assert.Contains``2(``0,System.Collections.Generic.IReadOnlyDictionary{``0,``1}))  
  Verifies that a dictionary contains a given key.
  
- [Contains<TKey, TValue>(TKey, ImmutableDictionary<TKey, TValue>)](xref:Xunit.Assert.Contains``2(``0,System.Collections.Immutable.ImmutableDictionary{``0,``1}))  
  Verifies that a dictionary contains a given key.
  
- [Contains<TKey, TValue>(TKey, ReadOnlyDictionary<TKey, TValue>)](xref:Xunit.Assert.Contains``2(``0,System.Collections.ObjectModel.ReadOnlyDictionary{``0,``1}))  
  Verifies that a dictionary contains a given key.
  
- [DoesNotContain<TKey, TValue>(TKey, ConcurrentDictionary<TKey, TValue>)](xref:Xunit.Assert.DoesNotContain``2(``0,System.Collections.Concurrent.ConcurrentDictionary{``0,``1}))  
  Verifies that a dictionary does not contain a given key.  
  
- [DoesNotContain<TKey, TValue>(TKey, Dictionary<TKey, TValue>)](xref:Xunit.Assert.DoesNotContain``2(``0,System.Collections.Generic.Dictionary{``0,``1}))  
  Verifies that a dictionary does not contain a given key.
  
- [DoesNotContain<TKey, TValue>(TKey, IDictionary<TKey, TValue>)](xref:Xunit.Assert.DoesNotContain``2(``0,System.Collections.Generic.IDictionary{``0,``1}))  
  Verifies that a dictionary does not contain a given key.
  
- [DoesNotContain<TKey, TValue>(TKey, IReadOnlyDictionary<TKey, TValue>)](xref:Xunit.Assert.DoesNotContain``2(``0,System.Collections.Generic.IReadOnlyDictionary{``0,``1}))  
  Verifies that a dictionary does not contain a given key.
  
- [DoesNotContain<TKey, TValue>(TKey, ImmutableDictionary<TKey, TValue>)](xref:Xunit.Assert.DoesNotContain``2(``0,System.Collections.Immutable.ImmutableDictionary{``0,``1}))  
  Verifies that a dictionary does not contain a given key.
  
- [DoesNotContain<TKey, TValue>(TKey, ReadOnlyDictionary<TKey, TValue>)](xref:Xunit.Assert.DoesNotContain``2(``0,System.Collections.ObjectModel.ReadOnlyDictionary{``0,``1}))  
  Verifies that a dictionary does not contain a given key.

## EqualityAsserts

- [Equal(DateTime, DateTime)](xref:Xunit.Assert.Equal(System.DateTime,System.DateTime))  
  Verifies that two DateTime values are equal.

- [Equal(DateTime, DateTime, TimeSpan)](xref:Xunit.Assert.Equal(System.DateTime,System.DateTime,System.TimeSpan))  
  Verifies that two DateTime values are equal, within the precision given by precision.

- [Equal(DateTimeOffset, DateTimeOffset)](xref:Xunit.Assert.Equal(System.DateTimeOffset,System.DateTimeOffset))  
  Verifies that two DateTimeOffset values are equal.

- [Equal(DateTimeOffset, DateTimeOffset, TimeSpan)](xref:Xunit.Assert.Equal(System.DateTimeOffset,System.DateTimeOffset,System.TimeSpan))  
  Verifies that two DateTimeOffset values are equal, within the precision given by precision.

- [Equal(Decimal, Decimal, Int32)](xref:Xunit.Assert.Equal(System.Decimal,System.Decimal,System.Int32))  
  Verifies that two decimal values are equal, within the number of decimal places given by precision. The values are rounded before comparison.

- [Equal(Double, Double, Double)](xref:Xunit.Assert.Equal(System.Double,System.Double,System.Double))  
  Verifies that two double values are equal, within the tolerance given by tolerance (positive or negative).

- [Equal(Double, Double, Int32)](xref:Xunit.Assert.Equal(System.Double,System.Double,System.Int32))  
  Verifies that two double values are equal, within the number of decimal places given by precision. The values are rounded before comparison.

- [Equal(Double, Double, Int32, MidpointRounding)](xref:Xunit.Assert.Equal(System.Double,System.Double,System.Int32,System.MidpointRounding))  
  Verifies that two double values are not equal, within the number of decimal places given by precision.  
  The values are rounded before comparison.  
  The rounding method to use is given by rounding

- [Equal(Float, Float, Int32)](xref:Xunit.Assert.Equal(System.Single,System.Single,System.Int32))  
  Verifies that two strings are equivalent.

- [Equal(Float, Float, Int32, MidpointRounding)](xref:Xunit.Assert.Equal(System.Single,System.Single,System.Int32,System.MidpointRounding))  
  Verifies that two float values are equal, within the number of decimal places given by precision. The values are rounded before comparison. The rounding method to use is given by rounding
  
- [Equal(Float, Float, Float)](xref:Xunit.Assert.Equal(System.Single,System.Single,System.Single))
  Verifies that two float values are equal, within the tolerance given by tolerance (positive or negative).

- [Equal\<T\>(T, T)](xref:Xunit.Assert.Equal``1(``0,``0))  
  Verifies that two objects are equal, using a default comparer.

- [Equal\<T\>(T, T, IEqualityComparer\<T\>)](xref:Xunit.Assert.Equal``1(``0,``0,System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that two objects are equal, using a custom equatable comparer.

- [Equal\<T\>(T, T, Func\<T, T, bool\>)](xref:Xunit.Assert.Equal``1(``0,``0,System.Func{``0,``0,System.Boolean}))  
  Verifies that two objects are equal, using a custom comparer function.

- [Equal\<T\>(T[], T[])](xref:Xunit.Assert.Equal``1(``0[],``0[]))  
  Verifies that two arrays of un-managed type T are equal, using Span<T>.SequenceEqual. This can be significantly faster than generic enumerables, when the collections are actually equal, because the system can optimize packed-memory comparisons for value type arrays.

- [NotEqual(Decimal, Decimal, Int32)](xref:Xunit.Assert.NotEqual(System.Decimal,System.Decimal,System.Int32))  
  Verifies that two decimal values are not equal, within the number of decimal places given by `precision`.

- [NotEqual(Double, Double, Double)](xref:Xunit.Assert.NotEqual(System.Double,System.Double,System.Double))  
  Verifies that two double values are not equal, within the tolerance given by tolerance (positive or negative).

- [NotEqual(Double, Double, Int32)](xref:Xunit.Assert.NotEqual(System.Double,System.Double,System.Int32))  
  Verifies that two double values are not equal, within the number of decimal places given by `precision`.

- [NotEqual(Double, Double, Int32, MidpointRounding)](xref:Xunit.Assert.NotEqual(System.Double,System.Double,System.Int32,System.MidpointRounding))  
  Verifies that two double values are not equal, within the number of decimal places given by `precision`. The values are rounded before comparison. The rounding method to use is given by `rounding`

- [NotEqual(Float, Float, Int32)](xref:Xunit.Assert.NotEqual(System.Single,System.Single,System.Int32))  
  Verifies that two float values are not equal, within the number of decimal places given by `precision`.

- [NotEqual(Float, Float, Int32, MidpointRounding)](xref:Xunit.Assert.NotEqual(System.Single,System.Single,System.Int32,System.MidpointRounding))  
  Verifies that two float values are not equal, within the number of decimal places given by `precision`. The values are rounded before comparison. The rounding method to use is given by `rounding`

- [NotEqual(Float, Float, Float)](xref:Xunit.Assert.NotEqual(System.Single,System.Single,System.Single))  
  Verifies that two float values are not equal, within the `tolerance` given by tolerance (positive or negative).

- [NotEqual\<T\>(T, T)](xref:Xunit.Assert.NotEqual``1(``0,``0))  
  Verifies that two objects are not equal, using a default comparer.

- [NotEqual\<T\>(T, T, IEqualityComparer\<T\>)](xref:Xunit.Assert.NotEqual``1(``0,``0,System.Collections.Generic.IEqualityComparer{``0}))  
  Verifies that two objects are not equal, using a custom equality comparer.

- [NotEqual\<T\>(T, T, Func<T, T, bool>)](xref:Xunit.Assert.NotEqual``1(``0,``0,System.Func{``0,``0,System.Boolean}))  
  Verifies that two objects are not equal, using a custom equality comparer function.

- [NotEqual\<T\>(T[], T[])](xref:Xunit.Assert.NotEqual``1(``0[],``0[]))  
  Verifies that two arrays of un-managed type T are not equal, using Span<T>.SequenceEqual.

- [NotStrictEqual\<T\>(T, T)](xref:Xunit.Assert.NotStrictEqual``1(``0,``0))  
  Verifies that two objects are strictly not equal, using the type's default comparer.

- [StrictEqual\<T\>(T, T)](xref:Xunit.Assert.StrictEqual``1(``0,``0))  
  Verifies that two objects are strictly equal, using the type's default comparer.

## EquivalenceAsserts

- [Equivalent(object?, object?, bool)](xref:Xunit.Assert.Equivalent(System.Object,System.Object,System.Boolean))  
  Verifies that two objects are equivalent, using a default comparer.  
  This comparison is done without regard to type, and only inspects public property and field values for individual equality.  
  Deep equivalence tests (meaning, property or fields which are themselves complex types) are supported. With strict mode off, object comparison allows `actual` to have extra public members that aren't part of `expected`,  
  and collection comparison allows `actual` to have more data in it than is present in `expected`;  
  with strict mode on, those rules are tightened to require exact member list (for objects) or data (for collections).

## EventAsserts

- [Raises(Action\<Action\>, Action\<Action\>, Action)](xref:Xunit.Assert.Raises(System.Action{System.Action},System.Action{System.Action},System.Action))  
  Verifies that an event is raised.

- [RaisesAny(Action\<EventHandler\>, Action\<EventHandler\>, Action)](xref:Xunit.Assert.RaisesAny(System.Action{System.EventHandler},System.Action{System.EventHandler},System.Action))  
  Verifies that an event is raised.

- [RaisesAnyAsync(Action\<EventHandler\>, Action\<EventHandler\>, Func\<Task\>)](xref:Xunit.Assert.RaisesAnyAsync(System.Action{System.EventHandler},System.Action{System.EventHandler},System.Func{System.Threading.Tasks.Task}))  
  Verifies that an event is raised.

- [RaisesAnyAsync\<T\>(Action<Action\<T\>\>, Action<Action\<T\>\>, Func\<Task\>)](xref:Xunit.Assert.RaisesAnyAsync``1(System.Action{System.Action{``0}},System.Action{System.Action{``0}},System.Func{System.Threading.Tasks.Task}))  
  Verifies that an event with the exact or a derived event args is raised.

- [RaisesAnyAsync\<T\>(Action<EventHandler\<T\>\>, Action<EventHandler\<T\>\>, Func\<Task\>)](xref:Xunit.Assert.RaisesAnyAsync``1(System.Action{System.EventHandler{``0}},System.Action{System.EventHandler{``0}},System.Func{System.Threading.Tasks.Task}))  
  Verifies that an event with the exact or a derived event args is raised.

- [RaisesAny\<T\>(Action<Action\<T\>\>, Action<Action\<T\>\>, Action)](xref:Xunit.Assert.RaisesAny``1(System.Action{System.Action{``0}},System.Action{System.Action{``0}},System.Action))  
  Verifies that an event with the exact or a derived event args is raised.

- [RaisesAny\<T\>(Action\<EventHandler\<T\>\>, Action<EventHandler\<T\>\>, Action)](xref:Xunit.Assert.RaisesAny``1(System.Action{System.EventHandler{``0}},System.Action{System.EventHandler{``0}},System.Action))  
  Verifies that an event with the exact or a derived event args is raised.

- [RaisesAsync(Action\<Action\>, Action\<Action\>, Func\<Task\>)](xref:Xunit.Assert.RaisesAsync(System.Action{System.Action},System.Action{System.Action},System.Func{System.Threading.Tasks.Task}))  
  Verifies that an event is raised.

- [RaisesAsync\<T\>(Action<Action\<T\>\>, Action<Action\<T\>\>, Func\<Task\>)](xref:Xunit.Assert.RaisesAsync``1(System.Action{System.Action{``0}},System.Action{System.Action{``0}},System.Func{System.Threading.Tasks.Task}))  
  Verifies that an event with the exact event args (and not a derived type) is raised.

- [RaisesAsync\<T\>(Action<EventHandler\<T\>\>, Action<EventHandler\<T\>\>, Func\<Task\>)](xref:Xunit.Assert.RaisesAsync``1(System.Action{System.EventHandler{``0}},System.Action{System.EventHandler{``0}},System.Func{System.Threading.Tasks.Task}))  
  Verifies that an event with the exact event args (and not a derived type) is raised.

- [Raises\<T\>(Action<Action\<T\>\>, Action<Action\<T\>\>, Action)](xref:Xunit.Assert.Raises``1(System.Action{System.Action{``0}},System.Action{System.Action{``0}},System.Action))  
  Verifies that an event with the exact event args is raised.

- [Raises\<T\>(Action<EventHandler\<T\>\>, Action<EventHandler\<T\>\>, Action)](xref:Xunit.Assert.Raises``1(System.Action{System.EventHandler{``0}},System.Action{System.EventHandler{``0}},System.Action))  
  Verifies that an event with the exact event args is raised.

- [Raises\<T\>(Func<EventAsserts.RaisedEvent\<T\>\>, Action, Action, Action)](xref:Xunit.Assert.Raises``1(System.Func{Xunit.Assert.RaisedEvent{``0}},System.Action,System.Action,System.Action))  
  Verifies that an event with the exact event args is raised.

## ExceptionAsserts Nullable

- [Throws(Type, Action)](xref:Xunit.Assert.Throws(System.Type,System.Action))  
  Verifies that the exact exception is thrown (and not a derived exception type).

- [Throws(Type, Func\<object?\>)](xref:Xunit.Assert.Throws(System.Type,System.Func{System.Object}))  
  Verifies that the exact exception is thrown (and not a derived exception type). Generally used to test property accessors.

- [ThrowsAnyAsync\<T\>(Func\<Task\>)](xref:Xunit.Assert.ThrowsAnyAsync``1(System.Func{System.Threading.Tasks.Task}))  
  Verifies that the exact exception or a derived exception type is thrown.

- [ThrowsAny\<T\>(Action)](xref:Xunit.Assert.ThrowsAny``1(System.Action))  
  Verifies that the exact exception or a derived exception type is thrown.

- [ThrowsAny\<T\>(Func\<object?\>)](xref:Xunit.Assert.ThrowsAny``1(System.Func{System.Object}))  
  Verifies that the exact exception or a derived exception type is thrown. Generally used to test property accessors.

- [ThrowsAsync(Type, Func\<Task\>)](xref:Xunit.Assert.ThrowsAsync(System.Type,System.Func{System.Threading.Tasks.Task}))  
  Verifies that the exact exception is thrown (and not a derived exception type).

- [ThrowsAsync\<T\>(Func\<Task\>)](xref:Xunit.Assert.ThrowsAsync``1(System.Func{System.Threading.Tasks.Task}))  
  Verifies that the exact exception is thrown (and not a derived exception type).

- [ThrowsAsync\<T\>(String?, Func\<Task\>)](xref:Xunit.Assert.ThrowsAsync``1(System.String,System.Func{System.Threading.Tasks.Task}))  
  Verifies that the exact exception is thrown (and not a derived exception type), where the exception derives from ArgumentException and has the given parameter name.

- [Throws\<T\>(Action)](xref:Xunit.Assert.Throws``1(System.Action))  
  Verifies that the exact exception is thrown (and not a derived exception type).

- [Throws\<T\>(Func\<object?\>)](xref:Xunit.Assert.Throws``1(System.Func{System.Object}))  
  Verifies that the exact exception is thrown (and not a derived exception type). Generally used to test property accessors.

- [Throws\<T\>(String?, Action)](xref:Xunit.Assert.Throws``1(System.String,System.Action))  
  Verifies that the exact exception is thrown (and not a derived exception type), where the exception derives from ArgumentException and has the given parameter name.

- [Throws\<T\>(String?, Func\<object?\>)](xref:Xunit.Assert.Throws``1(System.String,System.Func{System.Object}))  
  Verifies that the exact exception is thrown (and not a derived exception type), where the exception derives from ArgumentException and has the given parameter name.

## FailAsserts

- [Fail(string?)](xref:Xunit.Assert.Fail(System.String))  
  Indicates that the test should immediately fail.

## IdentityAsserts

- [NotSame(object?, object?)](xref:Xunit.Assert.NotSame(System.Object,System.Object))  
  Verifies that two objects are not the same instance.

- [Same(object?, object?)](xref:Xunit.Assert.Same(System.Object,System.Object))  
  Verifies that two objects are the same instance.

## MemoryAsserts

- [Contains\<T\>(Memory\<T\>, Memory\<T\>)](xref:Xunit.Assert.Contains``1(System.Memory{``0},System.Memory{``0}))  
  Verifies that a Memory contains a given sub-Memory

- [Contains\<T\>(Memory\<T\>, ReadOnlyMemory\<T\>)](xref:Xunit.Assert.Contains``1(System.Memory{``0},System.ReadOnlyMemory{``0}))  
  Verifies that a Memory contains a given sub-Memory

- [Contains\<T\>(ReadOnlyMemory\<T\>, Memory\<T\>)](xref:Xunit.Assert.Contains``1(System.ReadOnlyMemory{``0},System.Memory{``0}))  
  Verifies that a Memory contains a given sub-Memory

- [Contains\<T\>(ReadOnlyMemory\<T\>, ReadOnlyMemory\<T\>)](xref:Xunit.Assert.Contains``1(System.ReadOnlyMemory{``0},System.ReadOnlyMemory{``0}))  
  Verifies that a Memory contains a given sub-Memory

- [DoesNotContain\<T\>(Memory\<T\>, Memory\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.Memory{``0},System.Memory{``0}))  
  Verifies that a Memory does not contain a given sub-Memory

- [DoesNotContain\<T\>(Memory\<T\>, ReadOnlyMemory\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.Memory{``0},System.ReadOnlyMemory{``0}))  
  Verifies that a Memory does not contain a given sub-Memory

- [DoesNotContain\<T\>(ReadOnlyMemory\<T\>, Memory\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.ReadOnlyMemory{``0},System.Memory{``0}))  
  Verifies that a Memory does not contain a given sub-Memory

- [DoesNotContain\<T\>(ReadOnlyMemory\<T\>, ReadOnlyMemory\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.ReadOnlyMemory{``0},System.ReadOnlyMemory{``0}))  
  Verifies that a Memory does not contain a given sub-Memory

- [Equal\<T\>(Memory\<T\>, Memory\<T\>)](xref:Xunit.Assert.Equal``1(System.Memory{``0},System.Memory{``0}))  
  Verifies that two Memory values are equivalent.

- [Equal\<T\>(Memory\<T\>, ReadOnlyMemory\<T\>)](xref:Xunit.Assert.Equal``1(System.Memory{``0},System.ReadOnlyMemory{``0}))  
  Verifies that two Memory values are equivalent.

- [Equal\<T\>(ReadOnlyMemory\<T\>, Memory\<T\>)](xref:Xunit.Assert.Equal``1(System.ReadOnlyMemory{``0},System.Memory{``0}))  
  Verifies that two Memory values are equivalent.

- [Equal\<T\>(ReadOnlyMemory\<T\>, ReadOnlyMemory\<T\>)](xref:Xunit.Assert.Equal``1(System.ReadOnlyMemory{``0},System.ReadOnlyMemory{``0}))  
  Verifies that two Memory values are equivalent.

## MultipleAsserts

- [Multiple(params Action[])](xref:Xunit.Assert.Multiple(System.Action[]))  
  Runs multiple checks, collecting the exceptions from each one, and then bundles all failures up into a single assertion failure.

## NullAsserts

- [NotNull(object?)](xref:Xunit.Assert.NotNull(System.Object))  
  Verifies that an object reference is not null.

- [NotNull\<T\>(T?)](xref:Xunit.Assert.NotNull``1(System.Nullable{``0}))  
  Verifies that a nullable struct value is not null.

- [Null(object?)](xref:Xunit.Assert.Null(System.Object))  
  Verifies that an object reference is null.

- [Null\<T\>(T?)](xref:Xunit.Assert.Null``1(System.Nullable{``0}))  
  Verifies that a nullable struct value is null.

## PropertyAsserts

- [PropertyChanged(INotifyPropertyChanged, string, Action)](xref:Xunit.Assert.PropertyChanged(System.ComponentModel.INotifyPropertyChanged,System.String,System.Action))  
  Verifies that the provided object raised PropertyChanged as a result of executing the given test code.

- [PropertyChangedAsync(INotifyPropertyChanged, string, Func\<Task\>)](xref:Xunit.Assert.PropertyChangedAsync(System.ComponentModel.INotifyPropertyChanged,System.String,System.Func{System.Threading.Tasks.Task}))  
  Verifies that the provided object raised PropertyChanged as a result of executing the given test code.

## RangeAsserts

- [InRange\<T\>(T, T, T)](xref:Xunit.Assert.InRange``1(``0,``0,``0))  
  Verifies that a value is within a given range.

- [InRange\<T\>(T, T, T, IComparer\<T\>)](xref:Xunit.Assert.InRange``1(``0,``0,``0,System.Collections.Generic.IComparer{``0}))  
  Verifies that a value is within a given range, using a comparer.

- [NotInRange\<T\>(T, T, T)](xref:Xunit.Assert.NotInRange``1(``0,``0,``0))  
  Verifies that a value is not within a given range, using the default comparer.

- [NotInRange\<T\>(T, T, T, IComparer\<T\>)](xref:Xunit.Assert.NotInRange``1(``0,``0,``0,System.Collections.Generic.IComparer{``0}))  
Verifies that a value is not within a given range, using a comparer.

## Record

- [RecordException(Action)](xref:Xunit.Assert.RecordException(System.Action))  
  Records any exception which is thrown by the given code.

- [RecordException(Func<object?>, string)](xref:Xunit.Assert.RecordException(System.Func{System.Object},System.String))  
  Records any exception which is thrown by the given code that has a return value. Generally used for testing property accessors.

- [RecordExceptionAsync(Func\<Task\>)](xref:Xunit.Assert.RecordExceptionAsync(System.Func{System.Threading.Tasks.Task}))  
  Records any exception which is thrown by the given task.

## SetAsserts

- [Contains\<T\>(T, HashSet\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Generic.HashSet{``0}))  
  Verifies that the hashset contains the given object.

- [Contains\<T\>(T, ISet\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Generic.ISet{``0}))  
  Verifies that the set contains the given object.

- [Contains\<T\>(T, SortedSet\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Generic.SortedSet{``0}))  
  Verifies that the sorted hashset contains the given object.

- [Contains\<T\>(T, ImmutableHashSet\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Immutable.ImmutableHashSet{``0}))  
  Verifies that the immutable hashset contains the given object.

- [Contains\<T\>(T, ImmutableSortedSet\<T\>)](xref:Xunit.Assert.Contains``1(``0,System.Collections.Immutable.ImmutableSortedSet{``0}))  
  Verifies that the immutable sorted hashset contains the given object.

- [DoesNotContain\<T\>(T, HashSet\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Generic.HashSet{``0}))  
  Verifies that the hashset does not contain the given item.

- [DoesNotContain\<T\>(T, ISet\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Generic.ISet{``0}))  
  Verifies that the set does not contain the given item.

- [DoesNotContain\<T\>(T, SortedSet\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Generic.SortedSet{``0}))  
  Verifies that the sorted hashset does not contain the given item.

- [DoesNotContain\<T\>(T, ImmutableHashSet\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Immutable.ImmutableHashSet{``0}))  
  Verifies that the immutable hashset does not contain the given item.

- [DoesNotContain\<T\>(T, ImmutableSortedSet\<T\>)](xref:Xunit.Assert.DoesNotContain``1(``0,System.Collections.Immutable.ImmutableSortedSet{``0}))  
  Verifies that the immutable sorted hashset does not contain the given item.

- [ProperSubset\<T\>(ISet\<T\>, ISet\<T\>)](xref:Xunit.Assert.ProperSubset``1(System.Collections.Generic.ISet{``0},System.Collections.Generic.ISet{``0}))  
  Verifies that a set is a proper subset of another set.

- [ProperSuperset\<T\>(ISet\<T\>, ISet\<T\>)](xref:Xunit.Assert.ProperSuperset``1(System.Collections.Generic.ISet{``0},System.Collections.Generic.ISet{``0}))  
  Verifies that a set is a proper superset of another set.

- [Subset\<T\>(ISet\<T\>, ISet\<T\>)](xref:Xunit.Assert.Subset``1(System.Collections.Generic.ISet{``0},System.Collections.Generic.ISet{``0}))  
  Verifies that a set is a subset of another set.

- [Superset\<T\>(ISet\<T\>, ISet\<T\>)](xref:Xunit.Assert.Superset``1(System.Collections.Generic.ISet{``0},System.Collections.Generic.ISet{``0}))  
  Verifies that a set is a superset of another set.

## SkipAsserts

- [Skip(string)](xref:Xunit.Assert.Skip(System.String))  
  Skips the current test. Used when determining whether a test should be skipped happens at runtime rather than at discovery time.

- [SkipUnless(bool, string)](xref:Xunit.Assert.SkipUnless(System.Boolean,System.String))  
  Will skip the current test unless `condition` evaluates to `true`.

- [SkipWhen(bool, string)](xref:Xunit.Assert.SkipWhen(System.Boolean,System.String))  
  Will skip the current test when `condition` evaluates to `true`.

## SpanAsserts

- [Contains\<T\>(ReadOnlySpan\<T\>, ReadOnlySpan\<T\>)](xref:Xunit.Assert.Contains``1(System.ReadOnlySpan{``0},System.ReadOnlySpan{``0}))  
  Verifies that a span contains a given sub-span

- [Contains\<T\>(ReadOnlySpan\<T\>, Span\<T\>)](xref:Xunit.Assert.Contains``1(System.ReadOnlySpan{``0},System.Span{``0}))  
  Verifies that a span contains a given sub-span

- [Contains\<T\>(Span\<T\>, ReadOnlySpan\<T\>)](xref:Xunit.Assert.Contains``1(System.Span{``0},System.ReadOnlySpan{``0}))  
  Verifies that a span contains a given sub-span

- [Contains\<T\>(Span\<T\>, Span\<T\>)](xref:Xunit.Assert.Contains``1(System.Span{``0},System.Span{``0}))  
  Verifies that a span contains a given sub-span

- [DoesNotContain\<T\>(ReadOnlySpan\<T\>, ReadOnlySpan\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.ReadOnlySpan{``0},System.ReadOnlySpan{``0}))  
  Verifies that a span does not contain a given sub-span

- [DoesNotContain\<T\>(ReadOnlySpan\<T\>, Span\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.ReadOnlySpan{``0},System.Span{``0}))  
  Verifies that a span does not contain a given sub-span

- [DoesNotContain\<T\>(Span\<T\>, ReadOnlySpan\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.Span{``0},System.ReadOnlySpan{``0}))  
  Verifies that a span does not contain a given sub-span

- [DoesNotContain\<T\>(Span\<T\>, Span\<T\>)](xref:Xunit.Assert.DoesNotContain``1(System.Span{``0},System.Span{``0}))  
  Verifies that a span does not contain a given sub-span

- [Equal\<T\>(ReadOnlySpan\<T\>, ReadOnlySpan\<T\>)](xref:Xunit.Assert.Equal``1(System.ReadOnlySpan{``0},System.ReadOnlySpan{``0}))  
  Verifies that two spans contain the same values in the same order.

- [Equal\<T\>(ReadOnlySpan\<T\>, Span\<T\>)](xref:Xunit.Assert.Equal``1(System.ReadOnlySpan{``0},System.Span{``0}))  
  Verifies that two spans contain the same values in the same order.

- [Equal\<T\>(ReadOnlySpan\<T\>, T\[\])](xref:Xunit.Assert.Equal``1(System.ReadOnlySpan{``0},``0[]))  
  Verifies that a span and an array contain the same values in the same order.

- [Equal\<T\>(Span\<T\>, ReadOnlySpan\<T\>)](xref:Xunit.Assert.Equal``1(System.Span{``0},System.ReadOnlySpan{``0}))  
  Verifies that two spans contain the same values in the same order.

- [Equal\<T\>(Span\<T\>, Span\<T\>)](xref:Xunit.Assert.Equal``1(System.Span{``0},System.Span{``0}))  
  Verifies that two spans contain the same values in the same order.

## StringAsserts

- [Contains(string, string?)](xref:Xunit.Assert.Contains(System.String,System.String))  
  Verifies that a string contains a given sub-string, using the current culture.

- [Contains(string, string?, StringComparison)](xref:Xunit.Assert.Contains(System.String,System.String,System.StringComparison))  
  Verifies that a string contains a given sub-string, using the given comparison type.

- [Contains(Memory\<char\>, Memory\<char\>)](xref:Xunit.Assert.Contains(System.Memory{System.Char},System.Memory{System.Char}))  
  Verifies that a string contains a given sub-string, using the current culture.

- [Contains(Memory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.Contains(System.Memory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string contains a given sub-string, using the current culture.

- [Contains(ReadOnlyMemory\<char\>, Memory\<char\>)](xref:Xunit.Assert.Contains(System.ReadOnlyMemory{System.Char},System.Memory{System.Char}))  
  Verifies that a string contains a given sub-string, using the current culture.

- [Contains(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.Contains(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string contains a given sub-string, using the current culture.

- [Contains(Memory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.Memory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string contains a given sub-string, using the given comparison type.

- [Contains(Memory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.Memory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string contains a given sub-string, using the given comparison type.

- [Contains(ReadOnlyMemory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.ReadOnlyMemory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string contains a given sub-string, using the given comparison type.

- [Contains(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string contains a given sub-string, using the given comparison type.

- [Contains(Span\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.Span{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string contains a given string, using the given comparison type.

- [Contains(Span\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.Span{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string contains a given string, using the given comparison type.

- [Contains(ReadOnlySpan\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.ReadOnlySpan{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string contains a given string, using the given comparison type.

- [Contains(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.Contains(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string contains a given string, using the given comparison type.

- [Contains(Span\<char\>, Span\<char\>)](xref:Xunit.Assert.Contains(System.Span{System.Char},System.Span{System.Char}))  
  Verifies that a string contains a given string, using the current culture.

- [Contains(Span\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.Contains(System.Span{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string contains a given string, using the current culture.

- [Contains(ReadOnlySpan\<char\>, Span\<char\>)](xref:Xunit.Assert.Contains(System.ReadOnlySpan{System.Char},System.Span{System.Char}))  
  Verifies that a string contains a given string, using the current culture.

- [Contains(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.Contains(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string contains a given string, using the current culture.

- [DoesNotContain(string, string?)](xref:Xunit.Assert.DoesNotContain(System.String,System.String))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(string, string?, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.String,System.String,System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(Memory\<char\>, Memory\<char\>)](xref:Xunit.Assert.DoesNotContain(System.Memory{System.Char},System.Memory{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(Memory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.DoesNotContain(System.Memory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(ReadOnlyMemory\<char\>, Memory\<char\>)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlyMemory{System.Char},System.Memory{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(Memory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.Memory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(Memory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.Memory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(ReadOnlyMemory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlyMemory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(Span\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.Span{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(Span\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.Span{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(ReadOnlySpan\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlySpan{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string does not contain a given sub-string, using the given comparison type.

- [DoesNotContain(Span\<char\>, Span\<char\>)](xref:Xunit.Assert.DoesNotContain(System.Span{System.Char},System.Span{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(Span\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.DoesNotContain(System.Span{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(ReadOnlySpan\<char\>, Span\<char\>)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlySpan{System.Char},System.Span{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotContain(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.DoesNotContain(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string does not contain a given sub-string, using the current culture.

- [DoesNotMatch(string, string?)](xref:Xunit.Assert.DoesNotMatch(System.String,System.String))  
  Verifies that a string does not match a regular expression.

- [DoesNotMatch(Regex, string?)](xref:Xunit.Assert.DoesNotMatch(System.Text.RegularExpressions.Regex,System.String))  
  Verifies that a string does not match a regular expression.

- [Empty(string)](xref:Xunit.Assert.Empty(System.String))  
  Verifies that a string is empty.

- [EndsWith(string?, string?)](xref:Xunit.Assert.EndsWith(System.String,System.String))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(string?, string?, StringComparison)](xref:Xunit.Assert.EndsWith(System.String,System.String,System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(Memory\<char\>, Memory\<char\>)](xref:Xunit.Assert.EndsWith(System.Memory{System.Char},System.Memory{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(Memory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.EndsWith(System.Memory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(ReadOnlyMemory\<char\>, Memory\<char\>)](xref:Xunit.Assert.EndsWith(System.ReadOnlyMemory{System.Char},System.Memory{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.EndsWith(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(Memory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.Memory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(Memory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.Memory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(ReadOnlyMemory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.ReadOnlyMemory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(Span\<char\>, Span\<char\>)](xref:Xunit.Assert.EndsWith(System.Span{System.Char},System.Span{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(Span\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.EndsWith(System.Span{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(ReadOnlySpan\<char\>, Span\<char\>)](xref:Xunit.Assert.EndsWith(System.ReadOnlySpan{System.Char},System.Span{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.EndsWith(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string ends with a given sub-string, using the current culture.

- [EndsWith(Span\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.Span{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(Span\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.Span{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(ReadOnlySpan\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.ReadOnlySpan{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [EndsWith(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.EndsWith(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string ends with a given sub-string, using the given comparison type.

- [Equal(string?, string?)](xref:Xunit.Assert.Equal(System.String,System.String))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(Memory\<char\>, Memory\<char\>)](xref:Xunit.Assert.Equal(System.Memory{System.Char},System.Memory{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(Memory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.Equal(System.Memory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlyMemory\<char\>, Memory\<char\>)](xref:Xunit.Assert.Equal(System.ReadOnlyMemory{System.Char},System.Memory{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.Equal(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(Memory\<char\>, Memory\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.Memory{System.Char},System.Memory{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(Memory\<char\>, ReadOnlyMemory\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.Memory{System.Char},System.ReadOnlyMemory{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlyMemory\<char\>, Memory\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.ReadOnlyMemory{System.Char},System.Memory{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(Span\<char\>, Span\<char\>)](xref:Xunit.Assert.Equal(System.Span{System.Char},System.Span{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(Span\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.Equal(System.Span{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlySpan\<char\>, Span\<char\>)](xref:Xunit.Assert.Equal(System.ReadOnlySpan{System.Char},System.Span{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.Equal(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that two strings are equivalent.

- [Equal(Span\<char\>, Span\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.Span{System.Char},System.Span{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(Span\<char\>, ReadOnlySpan\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.Span{System.Char},System.ReadOnlySpan{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(ReadOnlySpan\<char\>, Span\<char\>, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.ReadOnlySpan{System.Char},System.Span{System.Char},System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Equal(string?, string?, bool, bool, bool, bool)](xref:Xunit.Assert.Equal(System.String,System.String,System.Boolean,System.Boolean,System.Boolean,System.Boolean))  
  Verifies that two strings are equivalent.

- [Matches(string, string?)](xref:Xunit.Assert.Matches(System.String,System.String))  
  Verifies that a string matches a regular expression.

- [Matches(Regex, string?)](xref:Xunit.Assert.Matches(System.Text.RegularExpressions.Regex,System.String))  
  Verifies that a string matches a regular expression.

- [StartsWith(string?, string?)](xref:Xunit.Assert.StartsWith(System.String,System.String))  
  Verifies that a string starts with a given string, using the current culture.

- [StartsWith(string?, string?, StringComparison)](xref:Xunit.Assert.StartsWith(System.String,System.String,System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(Memory\<char\>, Memory\<char\>)](xref:Xunit.Assert.StartsWith(System.Memory{System.Char},System.Memory{System.Char}))  
  Verifies that a string starts with a given sub-string, using the current culture.

- [StartsWith(Memory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.StartsWith(System.Memory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string starts with a given sub-string, using the current culture.

- [StartsWith(ReadOnlyMemory\<char\>, Memory\<char\>)](xref:Xunit.Assert.StartsWith(System.ReadOnlyMemory{System.Char},System.Memory{System.Char}))  
  Verifies that a string starts with a given sub-string, using the current culture.

- [StartsWith(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>)](xref:Xunit.Assert.StartsWith(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char}))  
  Verifies that a string starts with a given sub-string, using the default StringComparison.CurrentCulture comparison type.

- [StartsWith(Memory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.Memory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(Memory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.Memory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(ReadOnlyMemory\<char\>, Memory\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.ReadOnlyMemory{System.Char},System.Memory{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(ReadOnlyMemory\<char\>, ReadOnlyMemory\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.ReadOnlyMemory{System.Char},System.ReadOnlyMemory{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(Span\<char\>, Span\<char\>)](xref:Xunit.Assert.StartsWith(System.Span{System.Char},System.Span{System.Char}))  
  Verifies that a string starts with a given sub-string, using the current culture.

- [StartsWith(Span\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.StartsWith(System.Span{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string starts with a given sub-string, using the current culture.

- [StartsWith(ReadOnlySpan\<char\>, Span\<char\>)](xref:Xunit.Assert.StartsWith(System.ReadOnlySpan{System.Char},System.Span{System.Char}))  
  Verifies that a string starts with a given sub-string, using the current culture.

- [StartsWith(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>)](xref:Xunit.Assert.StartsWith(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char}))  
  Verifies that a string starts with a given sub-string, using the current culture.

- [StartsWith(Span\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.Span{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(Span\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.Span{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(ReadOnlySpan\<char\>, Span\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.ReadOnlySpan{System.Char},System.Span{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

- [StartsWith(ReadOnlySpan\<char\>, ReadOnlySpan\<char\>, StringComparison)](xref:Xunit.Assert.StartsWith(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.StringComparison))  
  Verifies that a string starts with a given sub-string, using the given comparison type.

## TypeAsserts

- [IsAssignableFrom(Type, object?)](xref:Xunit.Assert.IsAssignableFrom(System.Type,System.Object))  
  Verifies that an object is of the given type or a derived type.

- [IsAssignableFrom\<T\>(object?)](xref:Xunit.Assert.IsAssignableFrom``1(System.Object))  
  Verifies that an object is of the given type or a derived type.

- [IsNotAssignableFrom(Type, object?](xref:Xunit.Assert.IsNotAssignableFrom(System.Type,System.Object))  
  Verifies that an object is not of the given type or a derived type.

- [IsNotAssignableFrom\<T\>(object?)](xref:Xunit.Assert.IsNotAssignableFrom``1(System.Object))  
  Verifies that an object is not of the given type or a derived type.

- [IsNotType(Type, object?)](xref:Xunit.Assert.IsNotType(System.Type,System.Object))  
  Verifies that an object is not exactly the given type.

- [IsNotType(Type, object?, bool)](xref:Xunit.Assert.IsNotType(System.Type,System.Object,System.Boolean))  
  Verifies that an object is not of the given type.

- [IsNotType\<T\>(object?)](xref:Xunit.Assert.IsNotType``1(System.Object))  
  Verifies that an object is not exactly the given type.

- [IsNotType\<T\>(object?, bool)](xref:Xunit.Assert.IsNotType``1(System.Object,System.Boolean))  
  Verifies that an object is not of the given type.

- [IsType(Type, object?)](xref:Xunit.Assert.IsType(System.Type,System.Object))  
  Verifies that an object is exactly the given type (and not a derived type).

- [IsType(Type, object?, bool)](xref:Xunit.Assert.IsType(System.Type,System.Object,System.Boolean))  
  Verifies that an object is of the given type.

- [IsType\<T\>(object?)](xref:Xunit.Assert.IsType``1(System.Object))  
  Verifies that an object is exactly the given type (and not a derived type).

- [IsType\<T\>(object?, bool)](xref:Xunit.Assert.IsType``1(System.Object,System.Boolean))  
  Verifies that an object of is the given type.
