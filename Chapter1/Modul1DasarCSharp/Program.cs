// See https://aka.ms/new-console-template for more information
using Modul1DasarCSharp;

Console.WriteLine("Hello, World!");

Car mobilSaya = new Car();
mobilSaya.brand = "Mazda";
mobilSaya.model ="RX8";
mobilSaya.enginesize = 2000;

Console.WriteLine(mobilSaya.brand + mobilSaya.model + mobilSaya.enginesize.ToString());

