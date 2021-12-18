public class Minuman {
    public string Nama;
    public int Harga;


    public Minuman(string Nama, int Harga){
        this.Nama = Nama;
        this.Harga = Harga;
    }
    public Minuman(){
    }
}
public class Kopi : Minuman {
    public string JenisKopi;
}
public class NonKopi : Minuman {
    public string Rasa;
}
