/*
This program follows along this tutorial "https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp"
*/

Console.Clear();
//WorkWithIntegers();

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

int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);