open System.Runtime.InteropServices

module NativeRust =
    [<DllImport(@"..\..\..\..\native_rust\target\debug\native_rust", EntryPoint = "hello")>]
    extern void Hello()

    [<DllImport(@"..\..\..\..\native_rust\target\debug\native_rust", EntryPoint = "magic_function")>]
    extern int MagicFunction(int input)

[<EntryPoint>]
let main _ =
    NativeRust.Hello()

    let result = NativeRust.MagicFunction(42)
    printfn "Result: %d" result

    0