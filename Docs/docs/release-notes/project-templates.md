## Project Templates

### Enhanced Project Templates Enable Target Framework Overrides with --framework Option

We have updated the projects templates (shipped in `xunit.v3.templates`) to allow overriden target frameworks via `--framework` (or `-f`):

- `xunit3` allows `net8.0` (default), `net9.0`, `net472`, `net48`, and `net481`.

- `xunit3-extension` allows `netstandard2.0` (default), `net8.0`, `net9.0`, `net472`, `net48`, and `net481`.

The target framework override is also available when using the new templates inside Visual Studio and JetBrains Rider.
