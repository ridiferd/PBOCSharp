Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Reciever reciever = new Reciever();
invoker.SetOnFinish(new ComplexCommand(reciever, "Send email", "Save report"));

invoker.DoSomethingImportant();