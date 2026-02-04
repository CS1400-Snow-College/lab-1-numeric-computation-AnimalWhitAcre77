/*
This program follows along this tutorial "https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp"
*/

Console.Clear();
//WorkWithIntegers();
//OrderPrecedence();
//WorkWithIntegerLimits();
//WorkWithDoubles();

// 1: explore integer math
void WorkWithIntegers()
{
    int a = 18;
    int b = 6;

    // addition
    int c = a + b;
    Console.WriteLine(c);

    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

// 2: Explore order of operations
void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c; //multiplication takes priority over addition
    Console.WriteLine(d);

    d = (a + b) * c; //parenthesis take priority over multiplication
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g; //Type Integer will always return Type Integer, even if it isn't as accurate
    Console.WriteLine(h);
}

// 3: Interger precision and limits
void WorkWithIntegerLimits()
{
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c; // % operator gives remainder of division
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    int what = max + 3; //integers 'overflow' to the lowest value when you try to exceed the maximum value
    Console.WriteLine($"An example of overflow: {what}");
}

// 4: Work with the double type
void WorkWithDoubles()
{
    double a = 25;
    double b = 13;
    double c = (a + b) / 7;
    Console.WriteLine(c);

    double max = double.MaxValue; //double limits are much greater than int
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    double third = 1.0 / 3.0; //can truncate like int
    Console.WriteLine(third);

    double r = 2.3;
    double pi = 3.14;
    double circumference = 2 * r * pi;
    Console.WriteLine(circumference);
}

// 5: Work with decimal types
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b); 

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d); //Greater Precision than Double

// Calculate the area of a circle
double radius = 2.5;
double area = radius * radius * Math.PI;
Console.WriteLine($"The area of a {radius * 2} cm. circle is {area} cm.");