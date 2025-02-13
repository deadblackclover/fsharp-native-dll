# fsharp-native-dll

Example of using native libraries in F#

### Build native_rust

```sh
cargo build
```

### Build native_zig

Use version 0.13.0 to compile the library

```sh
zig build
```

### Build native_fsharp

```sh
dotnet publish -c Release -r <RUNTIME_IDENTIFIER> --self-contained
```
