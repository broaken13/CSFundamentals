# CS Fundamentals

This project goes over computer science fundamentals, primarily to be used as interview prep for large tech companies.

## Big O notation

Big O is a way to describe how an algorythm scales based on the size of an input. It looks like:

`O(n)`

While we generally want to reduce the Big O, it's important to remember that "less efficient" algorythms can still perform  better for smaller sizes of inputs due to overhead.

The various scales of Big O are:

#### O(1) - Constant
This means the operation takes the same amount of time regardless of the size of input.

#### O(log n) - Logarithmic
The operation can cover more inputs per cylce the more cycles it has to perform. Essentially, these get more efficient the larger the input size.

#### O(n) - Linear
The operation scales linearly, so inputs that are twice as big take roughly twice as long.

#### O(n log n) - Loglinear
N and Log n together.

#### O(n^2,3,4...) - Polynomial
Often involves a loops within a loops.

#### O(n!) - Factorial
Often comes from combinatorial problems.
