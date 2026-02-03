# Arrays & Collections Assignment - 2

1. **Array vs List**

| **Array** | **List** |
| --- | --- |
| Arrays are fixed size | List sizes are dynamic |
| Can’t be resized | Can be resized |
| It is build in in the language | Uses System.Collection.Genetic |
| Faster than arraylist | a bit slower |
1. **How dictionaries work internally.**

Dictionaries are collection which uses hash-table structure to store key values pairs.

It provides fast lookup times like O(n).

Dictionaries work basically with two arrays, i. Bucket and ii. Entries. Bucket stores the index or reference to the entries. and entries store actual key value pair.

When data is added, the dictionary uses a GetHasCode() function to get the hash value from the unique key. 

then i calculates bucket index using HashValue % bucket-size. which gets the index of bucket in which the reference is stored.

Entries store the actual key value pair. 

ex: Entries {

HashValue

key

value

next

}

next stores the pointer to next variable when collision happens.

Collision happens when two keys have same hash value. then the pointer to the first one is store in next.