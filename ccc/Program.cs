using System;
using System.Text.RegularExpressions;

//get input
string input = Console.ReadLine();

string pattern = @"\b\w+#?(-\w+)*\b";
//match with regex
var matches = Regex.Matches(input, pattern);
//calc the mean
int i = 0;
int sum = 0;
foreach (var match in matches)
{
    sum += match.ToString().Length;
    i++;
}
double result = (double)sum / (double)i;
//output the result
Console.WriteLine($"{Math.Ceiling(result*100)/100}");
