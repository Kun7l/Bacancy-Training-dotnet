# Operators Assignment-2

1. **Difference between == and Equals( )** 

== compares value after type promotion but in Equals() it compares values as well as types.

ex.

 if we right 2==2.0 will give true but 2.Equals(2.0) will return false. because in == case 2 will be converted to 2.0 and 2.0 == 2.0 so it returns true. but in Equals() case 2 is int and 2.0 is double so there is a type mismatch. So it returns false.

1. **Short-circuit behavior in logical operators**

Short circuit behavior usually happens in && and || operators. 

in && operator if first condition is false then it doesnt check the second one and returns false. Same in || when first condition is true it doesnt check the second one because the result will remain true. 

int x = 1;
if(x!=0 | | x/0 > 1)
{
Console.WriteLine("Entered");
}

here first condition x≠0 is true. so no need to check the other. If it would have checked the program will throws DevideByZeroException.

note : whenever you want to check both the expressions use & or | instead of && and ||