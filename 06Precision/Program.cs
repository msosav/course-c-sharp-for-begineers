int max = int.MaxValue;
int min = int.MinValue;

Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}\n");

// Working with doubles

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);
Console.WriteLine();

double maxDouble = double.MaxValue;
double minDouble = double.MinValue;

Console.WriteLine($"The range of double is {minDouble} to {maxDouble}\n");

double third = 1.0 / 3.0;
Console.WriteLine(third);
