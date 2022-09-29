// See https://aka.ms/new-console-template for more information
using Flee.PublicTypes;

Console.WriteLine("Hello, World!");
string domain = "x>=1 AND x<=1.5";
string range = "2*x-2";
double x = 1.3;

Console.WriteLine("Domain: {0}", domain);
Console.WriteLine("Range: {0}", range);
Console.WriteLine("x = {0}", x);
Console.WriteLine();

ExpressionContext expressionContext = new ExpressionContext();
expressionContext.Variables["x"] = x;

// is x = 1.3 within the domain?
IGenericExpression<bool> e = expressionContext.CompileGeneric<bool>(domain);
bool result = e.Evaluate();
Console.WriteLine("Is x = {0} within the domain?",x);
Console.WriteLine("Result: {0}", result);
Console.WriteLine();

// what is the answer for x = 1.3?
IGenericExpression<double> e2 = expressionContext.CompileGeneric<double>(range);
double result2 = e2.Evaluate();
Console.WriteLine("What is the answer for x = {0} in the range?", x);
Console.WriteLine("Result: {0}", result2.ToString("0.##"));
Console.WriteLine();

Console.WriteLine("Bye, World!");
Console.WriteLine("Developed by Gary Wee.");