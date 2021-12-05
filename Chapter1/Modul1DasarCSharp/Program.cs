// See https://aka.ms/new-console-template for more information
using Modul1DasarCSharp;

Console.WriteLine("Hello, World!");

Car mobilSaya = new Car();
mobilSaya.brand = "Mazda";
mobilSaya.model ="RX8";
mobilSaya.enginesize = 2000;

Car mobilAnda = new Car("Toyota","FT86", 2000);

mobilAnda.StartEngine();

int hasil = mobilAnda.CurrentSpeed(70);
Console.WriteLine(hasil);

Console.WriteLine(mobilSaya.brand + mobilSaya.model + mobilSaya.enginesize.ToString());

Car.DisplayCar();

double avg = mobilAnda.AverageSpeed(40,50,60,80,70,80,100);
Console.WriteLine(avg);


Console.ReadLine();

