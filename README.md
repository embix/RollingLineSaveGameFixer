# RollingLineSaveGameFixer

try fix corrupted RollingLine save game files by loading them without wagons and then saving them again.

## Build

Use either visual studio or dotnet command line as follows:

```
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained true
```

In case you want to target another platform use win-x32, linux-64, osx-64 or whatever

You find the build output in `bin\Debug\net5.0\$PLATFORM\publish`.
