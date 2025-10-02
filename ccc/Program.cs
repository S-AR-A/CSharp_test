using System;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

var dt = new DateTime(1300, 02, 04, 12, 11, 10);
System.Console.WriteLine(dt);
double number = double.Parse(Console.ReadLine());
var ts = new TimeSpan(0,0,(int)(number*3600));
dt=dt.Add(ts);
System.Console.WriteLine(dt);
