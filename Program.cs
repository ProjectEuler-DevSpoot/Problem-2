/*
 * Project Euler Problem 2
 * 
 * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
 * 
 * @author Nathaniel A. Rivera
 * @modified 7/29/24 0921 PDT
 */

int totalSum = 0;

int currentTerm = 1;
int prevTerm = 1;

while(currentTerm < 4_000_001)
{
    int preTerm = currentTerm;
    currentTerm = prevTerm + currentTerm;

    prevTerm = preTerm;

    if(currentTerm % 2 == 0) { totalSum += currentTerm; }

    Console.WriteLine($"{currentTerm} | Prev: {prevTerm} | Total: {totalSum}");
}

Console.WriteLine($"The total sum is: {totalSum}");