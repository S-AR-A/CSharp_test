//get the string
using System.Data;

var input = Console.ReadLine();
//split to str and index
string[] parts = input.Split(',');

var index = int.Parse(parts[1].Trim());

//remove the character 
var result = parts[0].Trim().Remove(index, 1);
//write result
Console.WriteLine(result);