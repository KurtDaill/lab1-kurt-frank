# Lab 1 

##### Frank Dozen || Kurt Daill
----
## 1
If the original fizzbuzz solution had to work off of a constant
instead of an argument, it would be entirely possible to simply
print an pre-written array, without any need to calculate further
values. 

----
## 2
It would have been possible to test the solution from part two 
by making a method that ran the code encapsulated within the 
original for loop, accepting and returning a single value.

----
## 3
Parts 3 and 4 are functionally the same, except for how their data
is stored (in either Arrays or Array Lists). As the length of the
Array or List is known by the time it's initialized, the only difference
is in memory usage. Arrays are generally more memory efficent, though 
Lists leave the developer open to make more changes more easily in future.
Which is used depends on the needs of the project. Part 2 is different becasue
it doesn't store its data to be used later, it merely prints. In function, part 2 does
something entirely different from the other two, and by not storing the data is something
of a 'dead end' in terms of future development.