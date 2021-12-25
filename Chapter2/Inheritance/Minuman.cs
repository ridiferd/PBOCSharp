public class Minuman {
    public string Nama;
    public int Harga;


    public Minuman(string Nama, int Harga){
        this.Nama = Nama;
        this.Harga = Harga;
    }
    public Minuman(){
    }

    public void DisplayMinuman()
    {

    }

    protected void IsMinuman()
    {

    }

    public void RasaMinuman()
    {
        Console.WriteLine("Rasa Minuman");
    }
}
public class Kopi : Minuman {
    public string JenisKopi;

    public void RoastKopi()
    {
        base.IsMinuman();
    }

    new public void RasaMinuman()
    {
        Console.WriteLine("didominasi rasa pahit");
    }

    
}
public class NonKopi : Minuman {
    public string Rasa;

    public void AddTopping()
    {

    }
}
