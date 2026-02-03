# Control Flow Assignment 2

1. **When Switch-case is preferable?**

Switch case is preferable to an if-else statement when dealing with multiple possible values for a single variable. it improves readability of code and simplifies it.

Switch case is evaluated only once and then compared against each cases rather then re-evaluating every time. which improves the performance.

1. **Enhancements in Switch**
    
    ### The Switch Expression
    
    . It allows you to return a value directly, turning the switch into an expression rather than a multi-line statement.
    
     It removes the repetitive case and break keywords.
    
    _ descard Replaces the defatlu keyword.
    
    comparison operators (<, >, ≤, ≥) and logical operators (and, or, not) directly within the switch arms. This eliminates the need for complex when guards for simple range checks.