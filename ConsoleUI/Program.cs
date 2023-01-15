using CoreMath.Trigonometry;
using CoreMath.Trigonometry.Functions;

var angle = new Degree();
angle.Value = 510;
Console.WriteLine(TrigonometricFunctions.Sin(angle));
Console.WriteLine("Hello, World!");
Console.WriteLine(Math.Sin(angle.ToRadian().GetExactValue()));
Console.WriteLine(angle.GetExactValue());