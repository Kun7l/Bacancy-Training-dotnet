# Generics

1. **Type safety**

Generics give type safety by compile time checking. If you put wrong data type into collection. The code will not run. This will catch issues before running the program.

No casting required since its strictly enforced during compile time.

1. P**erformance benefits**
    
    Generics avoid boxing and unboxing. Which allocates memory on stack rather than heap which makes execution faster.
    
    Type safety gives error at compile time so it reduces typechecking and casting at runtime which improves performance.
    
    For value types, JIT creates specialized code**.** Avoids object-based handling