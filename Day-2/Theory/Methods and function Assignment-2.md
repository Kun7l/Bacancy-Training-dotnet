# Methods and function

1. **Parameter passing mechanism**
    
    ### **Pass by Value :**
    
    When you pass a variable normally, the method creates a **copy** of the data. Changes made inside the method stay inside the method.
    
    ### **Pass by Reference :**
    
    Instead of a copy, you pass a "pointer" to the original variable in memory. Changes made inside the method **directly affect** the original variable.
    
    We use ref and out keyword in pass by reference. When we need to initialize variable we use ref, and out can be used when returning multiple values or change value of variable without initializing it outside the function.
    
2. **Value returning vs void**
    
    ### **Value-Returning Methods**
    
    These methods must specify a **Data Type** (like int, string, or a custom class). They act like a mathematical function: you provide input, and it provides a result.
    
    ex. public int add(int a,int b) return a+b;
    
    ### **Void Methods**
    
    The keyword void means "nothing." Use this when the method's purpose is to perform an action (like printing to a console, saving to a database, or updating a UI) rather than calculating a result.
    
    ex. void display() Console.WriteLine(”Hello world”);