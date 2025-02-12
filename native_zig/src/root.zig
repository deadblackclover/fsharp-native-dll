const std = @import("std");

export fn hello() void {
    std.debug.print("Hello from native_zig.dll\n", .{});
}
