using System.Drawing;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
InterfaceSample.Rectangle a = new InterfaceSample.Rectangle();
double hasil = a.CalculateArea(12,25);
a.GetColor();

InterfaceSample.IPolygon b = new InterfaceSample.Rectangle();
hasil = b.CalculateArea(23,12);
