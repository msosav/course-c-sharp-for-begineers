// Decimals have a higher precision than floats and doubles, and are typically used in financial and monetary calculations.
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;

Console.WriteLine($"The range of the decimal type is {min} to {max}\n");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);
Console.WriteLine();

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
Console.WriteLine();

// Challenge: Write a program that calculates the area of a circle.
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
