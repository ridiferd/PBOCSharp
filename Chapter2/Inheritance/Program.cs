// See https://aka.ms/new-console-template for more information

/* Menu */
Minuman airPutih = new Minuman() {Nama = "Air Putih", Harga = 1000};
Minuman airEs = new Minuman() { Nama ="Air Es", Harga = 1500 };


Kopi Arabica = new Kopi() { Nama= "Espresso", JenisKopi = "Arabica", Harga = 6000};
Kopi Robusta = new Kopi() { Nama = "Espresso", JenisKopi = "Robusta", Harga = 7000 };
Kopi EsKopiSusu = new Kopi() { Nama = "Es Kopi Susu", JenisKopi = "Robusta", Harga= 6500 };
EsKopiSusu.RoastKopi();
EsKopiSusu.RasaMinuman();

Minuman a = EsKopiSusu;
a.RasaMinuman();

NonKopi Susu = new NonKopi() { Nama = "Susu", Harga = 7500, Rasa = "Vanilla/Coklat/Cookies/Strawberri" };
NonKopi Sirup = new NonKopi() { Nama = "Sirup", Harga = 5000, Rasa = "Leci/Mangga/Jeruk/Melon/Strawberry/Mocca"};
Sirup.AddTopping();




Console.WriteLine("Selamat Datang di Warung Kopi Hitam Manis");
Console.WriteLine("-------------");
Console.WriteLine("Menu :");
Console.WriteLine("{0} : Rp {1}", airPutih.Nama, airPutih.Harga);
Console.WriteLine("{0} : Rp {1}", airEs.Nama, airEs.Harga);

Console.WriteLine("{0} - {1} : Rp {2}", Arabica.Nama, Arabica.JenisKopi, Arabica.Harga);
Console.WriteLine("{0} - {1} : Rp {2}", Robusta.Nama, Robusta.JenisKopi, Robusta.Harga);
Console.WriteLine("{0} - {1} : Rp {2}", EsKopiSusu.Nama, EsKopiSusu.JenisKopi, EsKopiSusu.Harga);

Console.WriteLine("{0} Rasa {1} : Rp {2}", Susu.Nama, Susu.Rasa, Susu.Harga);
Console.WriteLine("{0} Rasa {1} : Rp {2}", Sirup.Nama, Sirup.Rasa, Sirup.Harga);
Console.WriteLine("-------------");
