/*
This program follows along this tutorial "https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp"
*/

Console.Clear();
//WorkWithIntegers();
OrderPrecedence();

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