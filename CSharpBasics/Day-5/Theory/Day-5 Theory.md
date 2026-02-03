# Day-5

1. **Performance impact of boxing**
    
    Boxing requires runtime to allocate memory on the managed heap and a object to wrap the value, which is much more expensive then storing it onto a stack.
    
    Every boxed value creates a new object on the heap that must be tracked and removed by the garbage collector.
    
    due to runtime type checking, boxing is much costlier than normal assignment.
    
    Values on stack can use CPU cache which makes them accessing faster while boxed values are on much slower heap memory.
    
2. Delegates vs Interface 
    
    
    | **Delegates** | **Interfaces** |
    | --- | --- |
    | a reference to methods having same signature. | A contract for a group of members (methods, properties). |
    | Any method with a matching signature can be accessed. |  Classes must explicitly implement the interface by name. |
    | Supports multicast (chaining multiple methods). | Does not support method chaining directly. |
    | Can wrap existing methods, anonymous methods, or lambdas. | Requires a full class or struct definition to implement. |