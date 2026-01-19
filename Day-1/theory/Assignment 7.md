# Assignment 7

| Feature | const | readonly |
| --- | --- | --- |
| **Initialization** | Must be initialized **at the time of declaration** | Can be initialized **at declaration or inside a constructor** |
| **Runtime behavior** | Value is **replaced at compile time** (compile-time constant) | Value is **assigned at runtime** |
| **Use cases** | Fixed values that never change and are known at compile time (e.g., mathematical constants, fixed strings) | Values that should not change after object creation but may differ per instance (e.g., configuration values, IDs) |