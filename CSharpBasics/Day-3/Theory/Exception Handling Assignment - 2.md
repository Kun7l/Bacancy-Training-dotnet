# Exception Handling

1. **Exception handling vs suppression**

### Exception Handling

Handling is the process of catching an error, understanding why it happened, and taking corrective action to keep the application stable.

Uses try-catch-finally blocks. Saferecovery. You might log the error, notify the user, or try an alternative path.

### Exception Suppression

Suppression is the act of catching an exception and doing absolutely nothing with it. 

 An empty catch block which doesnt do anything.  To prevent the app from crashing at all costs, regardless of whether the operation succeeded. 

1. **Risks of empty catch blocks**
    
    An empty catch block is dangerous because it hides bugs and causes silent failures**.** By "swallowing" an error without logging it, you lose the ability to see what went wrong or where the code failed. This makes debugging nearly impossible and can leave your application in a **corrupted state**, where it continues to run but produces incorrect data or leaks system resources like memory and file locks.