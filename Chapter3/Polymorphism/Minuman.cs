public class Minuman {
    public string Nama;

    public Minuman(string Nama){
        this.Nama = Nama;
    }

    public Minuman() {

    }
    public virtual void Buat(){
        Console.WriteLine("Minuman {0} dibuat.", Nama);
    }

    public virtual void Buat(bool PakaiEs){
        string Dingin = "Dingin";
        if(!PakaiEs){
            Dingin = "";
        }

        Console.WriteLine("Minuman {0} {1} dibuat.", Nama, Dingin);
    }
}
public class Kopi : Minuman {
    public string JenisKopi;
    public bool PakaiGula;
    public string Gula;
    public Kopi(string Nama, string JenisKopi, bool PakaiGula) {
        this.Nama = Nama;
        this.JenisKopi = JenisKopi;
        this.PakaiGula = PakaiGula;
        this.Gula = PakaiGula ? "dengan gula" : "tanpa gula";
    }

    public override void Buat()
    {
        Console.WriteLine("Minuman {0} {1} {2} dibuat.", Nama, JenisKopi, Gula);
    }

    public override void Buat(bool PakaiEs)
    {
        string Es = "";

        if(PakaiEs){
            Es = "Es";
        }

        Console.WriteLine("Minuman {0} {1} {2} dengan {3} dibuat.", Es, Nama, JenisKopi, Gula);
        // Console.WriteLine("Minuman {0} {1} {2) dengan {3} dibuat.", Es, Nama, JenisKopi, Gula);
    }
}
public class Sirup : Minuman {
    public string Rasa;

 public Sirup(string nama, string rasa) {
        this.Nama = nama;
        this.Rasa = rasa;
       
    }


 public override void Buat()
    {
        Console.WriteLine("Minuman {0} dengan rasa {1} dibuat.", Nama, Rasa);
    }

    public override void Buat(bool PakaiEs)
    {
        string Es = "";

        if(PakaiEs){
            Es = "Es";
        }

        Console.WriteLine("Minuman {0} {1} dengan rasa {2} dibuat.", Es, Nama,Rasa);
        // Console.WriteLine("Minuman {0} {1} {2) dengan {3} dibuat.", Es, Nama, JenisKopi, Gula);
    }

}
