/*
This program follows along this tutorial "https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp"
*/

Console.Clear();
//WorkWithIntegers();
//OrderPrecedence();
//WorkWithIntegerLimits();

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
double a = 25;
double b = 13;
double c = (a + b) / 7; //Won't truncate like int at whole number scale
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
