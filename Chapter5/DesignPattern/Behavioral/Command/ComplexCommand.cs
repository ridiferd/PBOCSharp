class ComplexCommand : ICommand
{
    private Reciever _reciever;

    private string _a;
    private string _b;

    public ComplexCommand(Reciever reciever, string a, string b){
        this._reciever = reciever;
        this._a = a;
        this._b = b;
    }

    public void Execute()
    {
        Console.WriteLine("ComplexCommand: Complex stuff should be done by a reciever object.");
    }
}