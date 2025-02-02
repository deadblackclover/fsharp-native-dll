#[no_mangle]
pub extern "C" fn hello() {
    println!("Hello from native_rust.dll")
}

#[no_mangle]
pub extern "C" fn magic_function(input: i32) -> i32 {
    input + 42
}
