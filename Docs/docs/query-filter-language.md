# Query Filter Language

Query filter language allows you to filter tests based on namespace, fully qualified class names, fully qualified method names, and [traits](xref:Xunit.TraitAttribute).

> [!NOTE]  
> All string comparisons are done case insensitively. That means `/foo` and `/FOO` are the same query.
> [!IMPORTANT]
> In order to better reason about how filtering works, you may use either query filters or simple filters,  
> but you may **not** use both at the same time.

## Query is segmented

The query filter consists of up to four hierarchical segments, each representing a specific part of a fully qualified test method:

`/<assemblyFilter>/<namespaceFilter>/<classFilter>/<methodFilter>`

**Example**:

Let’s assume a test method of `MyNamespace.MySubNamespace.MyClass+MySubClass.MyTestMethod`  
that lives in `C:\Dev\MyProjects\Tests\bin\Debug\net8.0\MyTests.dll`:

- `assemblyFilter` is matched against the test assembly name `MyTests`
- `namespaceFilter` is matched against the namespace of the test `MyNamespace.MySubNamespace`
- `classFilter` is matched against the name of the test class `MyClass+MySubClass`
- `methodFilter` is matched against the name of the test method `MyTestMethod`

`/MyTests/MyNamespace.MySubNamespace/MyClass+MySubClass/MyTestMethod` will match the example test method above.

## Match All

For any segment, you can use `*` to represent a “match all”.

In addition, any segment left off the query is considered to be an implicit “match all”.

**Examples**:

- `/` is equivalent to `/*`, `/*/*`, `/*/*/*`, and `/*/*/*/*`.
- `/MyAssembly` is equivalent to `/MyAssembly/*`, `/MyAssembly/*/*`, and `/MyAssembly/*/*/*`.
- `/MyAssembly/MyNamespace` is equivalent to `/MyAssembly/MyNamespace` and `/MyAssembly/MyNamespace/*/*`.

> [!IMPORTANT]
> Queries **must** always start with **`/`**, **even** if you are not specifying any segment values.  
> Specifying **more** than four segments results in a parsing error for the query.

## Trait Filter

To filter based on a [trait](xref:Xunit.TraitAttribute), add an appropriate trait expression to the end of your query,  
in the form of `[name=value]` or `[name!=value]`.

**Examples**:

- `/[category=slow]`  
  means “run all tests that have a trait named `category` with a value named `slow`.
- `/[category!=slow]`  
  means “run all tests that do **not** have a trait named `category` with a value named `slow`.

## Wildcards to start/end a query expression

You may start and/or end a query expression with `*` to indicate a wildcard that matches 0 or more characters.  
This includes both segment query expressions as well as the `name` and/or `value` portion of a trait filter.

> [!IMPORTANT]
> The **`*`** wildcard is **only** allowed at the start or end, and **not** in the middle, of any query.

**Query segment examples**:

`query` means “match exactly against `query`”

- ✅ query (matches)
- ❌ 1query (does not match)
- ❌ query2 (does not match)
- ❌ 1query2 (does not match)

`query*` means “match against anything that starts with `query`”

- ✅ query (matches)
- ❌ 1query (does not match)
- ✅ query2 (matches)
- ❌ 1query2 (does not match)

`*query` means “match against anything that ends with `query`”

- ✅ query (matches)
- ✅ 1query (matches)
- ❌ query2 (does not match)
- ❌ 1query2 (does not match)

`*query*` means “match against anything that contains `query`”

- ✅ query (matches)
- ✅ 1query (matches)
- ✅ query2 (matches)
- ✅ 1query2 (matches)

**Trait filter example**:

- `[*name*=*value*]`  
  means “match against a trait whose `name` contains name and whose `value` contains value.

## Combine multiple queries

Within a single segment or a trait query, you may combine multiple matching patterns by using parenthesis,  
separated by either `|` (for OR) or `&` (for AND).  
Parenthesis in this situation are **not** optional.  

If your multipart query contains three or more pieces, they **must** either be all the same type (OR vs. AND),  
or **must** use extra parenthesis to indicate how the operators are to be grouped.  

- ✅ `(A)|(B)|(C)`.
- ❌ `(A)|(B)&(C)` must be expressed either as `((A)|(B))&(C)` or `(A)|((B)&(C))`.

Multipart queries **cannot** span across segment boundaries.

**Examples**:

- `/*/*/*/(False)|(True)`  
  means “run all tests whose test method is named either **False** or **True**”.
- `/[(name1=value1)&(name2=value2)]`  
  means “run all tests with both traits **name1=value1** and **name2=value2**.
- `/[((name1=value1a)|(name1=value1b))&(name2!=value2)]`  
  means “run all tests with either traits **name1=value1a** or **name1=value1b**, and also with no trait matching **name2=value2**.

## Negate a segment query

You may negate a segment query by prepending ! on the segment filter expression.

Note: If you are using wildcard expressions, the negate operator comes before the wildcard (i.e., !*, not *!). If you are combining multiple queries in a single segment, the negate operator is placed inside the parenthesis, not outside (i.e., (!expression), not !(expression)).

**Examples**:

- `/*/!*foo`  
  means “run all tests whose namespace does not end in foo”
- `/*/*/(Foo*)&(!*Bar)`  
  means “run all tests whose class name starts with Foo and does not end with Bar"

> [!IMPORTANT]
> Negating a trait query is done by using [name!=value], **not** ![name=value].

## Escaping special characters

You can escape special characters your terminal might not directly support, by encoding them using the [hexadecimal HTML character encoding scheme](https://en.wikipedia.org/wiki/Character_encodings_in_HTML).

Commonly escaped special characters:

- ! is \&#x21;
- ( is \&#x28;
- ) is \&#x29;
- / is \&#x2f;
- = is \&#x3d;
- [ is \&#x5b;
- ] is \&#x5d;

## Specifying a query filter

**Combining Multiple Filters**  

If you provide multiple filters in a single expression, xUnit treats them with **logical OR** behavior.

This means `-filter "/[category=fast] or [class=MyTests]"`

will match any test with `category=fast` **OR** any test in the `class MyTests`

**Running Tests in Different Modes**  

# [-Dotnet run](#tab/dotnet-run)

**Using** `dotnet run`

**Always** include `--` to separate dotnet CLI arguments from test runner arguments.

Filter by category (trait)

```shell
dotnet run -- -filter /[category=fast]
```

Filter by test name

```shell
dotnet run -- -filter "Fully.Qualified.Namespace.MyTestClass.MyTestMethod"
```

Combine multiple filters (OR)

```shell
dotnet run -- -filter "/[category=fast] | [category=critical]"
```

> [!NOTE]
> Be sure to wrap expressions with quotes if they contain spaces or special characters.

# [-xUnit console](#tab/xunit-console)

**Using** `xunit.v3.console.exe`

Use `-filter` for all query types.

Filter by category (trait)

```shell
xunit.v3.console.exe bin/Debug/net8.0/MyTests.dll -filter /[category=fast]
```

Filter by test name

```shell
xunit.v3.console.exe bin/Debug/net8.0/MyTests.dll -filter "MyNamespace.MyClass.MyMethod"
```

Multiple filters (OR)

```shell
xunit.v3.console.exe bin/Debug/net8.0/MyTests.dll -filter "/[category=fast] | [category=critical]"
```

Filtering across multiple assemblies

```shell
-filter "/MyAssembly.[category=fast]"
```

# [-xunit-exe](#tab/xunit-exe)

**Running the compiled test** `.exe` **directly**  

Use `-filter` as you would with the console runner.

Filter by category

```shell
bin/Debug/net8.0/MyTests.exe -filter /[category=fast]
```

Filter by test name

```shell
bin/Debug/net8.0/MyTests.exe -filter "MyNamespace.MyTestClass.MyMethod"
```

Multiple filters

```shell
bin/Debug/net8.0/MyTests.exe -filter "/[category=fast] | [category=slow]"
```

# [-dotnet-test](#tab/dotnet-test)

**Using** `dotnet test` **(Microsoft Testing Platform)**

Use `--filter-query` instead of `-filter`.  
**Always** include `--` to forward arguments to the test runner.

Filter by category

```shell
dotnet test -- --filter-query /[category=fast]
```

Filter by test name

```shell
dotnet test -- --filter-query "MyNamespace.MyClass.MyMethod"
```

Multiple filters

```shell
dotnet test -- --filter-query "/[category=fast] | [category=critical]"
```
