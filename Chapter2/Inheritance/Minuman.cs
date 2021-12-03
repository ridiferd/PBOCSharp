public class Minuman {
    public string Nama;
    public int Harga;
}
public class Kopi : Minuman {
    public string JenisKopi;
}
public class NonKopi : Minuman {
    public string Toping;
}
public class Susu : NonKopi {
    public string Campuran;
}