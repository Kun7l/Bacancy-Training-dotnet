# Lambda Expression

1. **Benefits of Lambda expression**
    
    Lambda Expression allows us to write short and readble code, In traditional methods the boiler plate of method is larger. Lambda reduces the boiler plate code. Which imroves readbility.
    
    We can create anonymus functions (functions without name) with the help of lambda function.
    
    It is helpful to create short helper methods
    
    ex : 
    
    ```csharp
    bool isAdult(int age) {
    return age>18;
    }
    
    //Lambda
    bool isAdult = age.Where(a=> a>18)
    ```
    
2. **Lambda vs Traditional methods**
    
    
    | **Traditional Methods** | **Lambda Function** |
    | --- | --- |
    | They are named methods. | They are anonymus methods. |
    | Syntax if longer then lambda. | Uses shorter syntax |
    | Reuseability is good. | Reusability is limited |
    | Scope is class | scope local |