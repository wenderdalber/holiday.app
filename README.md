# holiday.app
A simple api that calculates the Easter and Corpus Christi holidays, according to the year entered. Development with clean architecture, using mediator, with .NET 8 and unit tests.

Gaussian elimination, or scaling method, is an algorithm for solving systems of linear equations. This method consists of applying successive elementary operations to a linear system, to transform it into a system that is easier to solve, which presents exactly the same solutions as the original.

# Gauss algorithm

To calculate the exact date of each year there are several mathematical tools or methods. Even calculation tables were created for this purpose. The simplest and most well-known is Karl F. Gauss's algorithm, which is based on modular arithmetic, a very useful mathematical tool in different situations.

To use the method correctly, ten variables are used: a, b, c, k, p, q, M, N, d, e, and “A” is the year for which we want to calculate the Sunday date. Easter. Variables are defined like this:

a= A (mod19), is the remainder of dividing A by 19.
b= A (mod4), is the remainder of dividing A by 4.
c= A (mod7), is the remainder of dividing A by 7.
k= (A / 100), is the result of rounding down the result of this division.
p= ((13 + 8k) / 25), is the result of rounding down the result of this operation.
q= (k / 4), is the result of rounding down the result of dividing k by 4.
M= 15-p + kq (mod30), is the remainder of dividing 15-p + kq by 30.
N= 4 + kq (mod7), is the remainder of dividing 4 + kq by 7.
d= 19a + M (mod30), is the remainder of dividing 19a + M by 30.
e= 2b + 4c + 6d + N (mod 7), is the remainder of dividing 2b + 4c + 6d + N by 7.
After calculating all the variables for the desired year, we will have to:

If (d + e) ​<10, the date of Easter will be (d + e + 22) March.
If (d + e) > 9, the date of Easter will be (d + e-9) in April.
There are two exceptions to this rule:

If we reach April 26th (we leave the defined range), Easter will be April 19th.
If we get April 25th with d= 28, e = 6, a> 10, Easter will be April 18th.
To exemplify the method, let's calculate the date of Easter Sunday in this year 2021 (it should give us the result of April 4th, which is the date that appears in the almanac).

If A= 2021, then, doing the calculations, they result: a= 7, b= 1, c= 5, k= 20, p= 6, q= 5, M= 24, N= 5, d= 10, e= 3

As (d + e) = 13, it is greater than 9, so the date of Easter will be the day (d + e-9) of April, that is, April 4, and the calculation is correct! In fact, Easter falls on April 4, 2021

# Technologies

For this development, we use:
- Clean architecture;
- .NET 8;
- Mediator;
- NUnit for unit tests;
