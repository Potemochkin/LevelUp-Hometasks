namespace LevelUp.CsharpJuniors.Hometasks.Lesson2.Models

{
    internal class Store
    {
        public string Name { get; }
        public string Address { get;}
        public Store(string storeName, string storeAddress)
        {
            Name = storeName;
            Address = storeAddress;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nHere your data about store\nName store: {Name}\nAdress store: {Address}\n\nHave a good day! You are welcome :)");
        }
    }
}