# RollingLineSaveGameFixer

try fix corrupted RollingLine save game files by loading them without wagons and then saving them again.

## Build

Before you can build make sure you have a copy of RollingLine. You need to fix the `HintPath  ` for the reference to `Assembly-CSharp`  in the `.csproj`. Usually its something like `C:\Steam\steamapps\common\Rolling Line\RollingLine_Data\Managed\Assembly-CSharp.dll`.

Once that's fixed, you can  either use Visual Studio or use the dotnet command line as follows:

```
src\RollingLineSaveGameFixer
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained true
```

In case you want to target another platform use win-x32, linux-64, osx-64 or whatever

You find the build output in `bin\Debug\net5.0\$PLATFORM\publish`.

