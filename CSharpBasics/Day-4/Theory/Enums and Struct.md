# Enums and Struct

1. **Advantages of Enums**

**Type Safety :** Enum provides Type Safety which prevents from accidental changes in value. Because it gets checked at compile time. 

Ex :  

```csharp
enum StatusCode {
Success = 200,
Notfound = 404
}

StatusCode status = SatusCode.Success;
status = 500;
// Above line will give error
```

**Better Readability :**  Readability of code improves. 

Ex :

```csharp
if(status == 200)

if(status == StatusCode.Sucess)
```

Enums also prevents hardcoded values without any context. 

Enums imrove modularity of code. So we dont have to go thorough every line to change. We can directly change in enum and change will reflect everywhere.

1. **Limitations of struct**
    
    i ) No inheritance : You can not inherit or extend from any other struct or class.  Struct B : A {} is not allowed.
    
    ii ) Struct is value type : So while assigning to another struct or passing it in parameter to a function will result copying the whole struct. Which is very costly. If a very large struct is assigned or passed in parameter, the whole struct will get copied.
    
    iii ) Boxing and Unboxing creates a lot of overhead. 
    
    iv ) Mutable bugs : When we assign one struct to another it creates a copy. changing the field of copy will not change the initial struct’s field. which create unexpected behaviour.