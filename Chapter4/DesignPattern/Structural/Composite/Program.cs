﻿Client client = new Client();

Leaf leaf = new Leaf();
Console.WriteLine("Client: I get a simple component: ");
client.ClientCode(leaf);

Composite tree = new Composite();
Composite branch1 = new Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());

Composite branch2 = new Composite();
branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("Client: No I've got a composite tree: ");
client.ClientCode(tree);

Console.Write("Client: I don't need to check the components classes even when manangeing the tree: \n");
client.ClientCode2(tree, leaf);