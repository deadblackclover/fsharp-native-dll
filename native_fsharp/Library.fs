namespace native_fsharp

open System.Runtime.InteropServices

module Native =
    [<UnmanagedCallersOnly(EntryPoint = "hello")>]
    let hello () =
        printfn "Hello from native_fsharp.dll"
