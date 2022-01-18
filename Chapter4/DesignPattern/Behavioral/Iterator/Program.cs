var collection = new WordsCollection();
collection.Additem("First");
collection.Additem("Second");
collection.Additem("Third");

Console.WriteLine("Straight traversal: ");

foreach(var element in collection){
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal: ");
collection.ReverseDirection();

foreach(var element in collection){
    Console.WriteLine(element);
}