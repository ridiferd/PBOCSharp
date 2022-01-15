

// statik
// parameter berbeda nama fungsi sama dalam satu kelas

// dynamic
// fungsi sama parameter sama dalam kelas turunan

Minuman airPutih = new Minuman("Air Putih");
airPutih.Buat();
airPutih.Buat(true);

Kopi Arabica = new Kopi("Kopi", "Arabika", false);
Arabica.Buat();
Arabica.Buat(true);

var minuman = new List<Minuman>
{
    new Minuman(),
    new Sirup("Fruit Punch", "Jeruk"),
    new Kopi("Blended Coffe","Arabika", false)
};

foreach (var minum in minuman)
{
    minum.Buat();
} 
