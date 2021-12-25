namespace PhoneApp
{
public abstract class Phone {
    public abstract void MenerimaPanggilan();
    public abstract void MelakukanPanggilan();
    public abstract void Berbunyi();

    public abstract string Model { get; set; }
    
    public abstract string Brand { get; set; }
    
    protected string name;

}
}