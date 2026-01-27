# Day-6

1. **Async vs Multithreading**
    
    
    | **Async** | Multithreading |
    | --- | --- |
    | not blocking flow of execution while waiting for a task | doing many things at the same time using multiple threads |
    | Used for non-blocking waiting | Used for heavy calculations |
    | CPU usage is low | CPU usage is high |
    | Best for IO bound operations  | Best for CPU bound operations |
2. **Common async pitfalls**
    1. using Thread.sleep() with async methods : We should always use Task.delay() instead of Thread.sleep(). Because it block the thread.
    2. Not handling exceptions in async method : always handle exceptions in async method.
    3. async void : Use Task for async void functions so that exceptions can be handled and caller can wait.
    4. using .Result() instead of await