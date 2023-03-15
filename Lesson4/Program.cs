using Lesson4;

Console.WriteLine("Let's play with C#\nThis is hometask 4");

var generic = new SimpleGenericCache<string>();

generic.Store("One", "one store");
Console.WriteLine(generic.Fetch("One"));

generic.Store("Two", "two store", 0);
Console.WriteLine(generic.Fetch("Two"));

generic.Store("Three", "three store", 35);
Console.WriteLine(generic.Fetch("Three"));