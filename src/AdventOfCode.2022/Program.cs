// See https://aka.ms/new-console-template for more information

using AdventOfCode._2022.Day1;

// Manual testing
// Day 1
var input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";



var result1 = Day1Solution.GetMaxCalorieCount(input);
var result2 = Day1Solution.GetTotalCalorieReserves(input); 

Console.WriteLine(result1);
Console.WriteLine(result2);
