﻿double CalculateFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denominator = c + d;
    double result = numerator / denominator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);