using Lesson3.Interfaces;

namespace Lesson3.Hierarchy.Item
{
    internal sealed class Jacket : Wear, Information
    {
        public override double Price { get; set; }
        public override int Size { get; set; }
        public override string? Season { get; set; }
        public Jacket(string name, string description, string nomenclature, double price, int size, string season) :
            base(name, description, nomenclature)
        {
            Price = price;
            Size = size;
            Season = season;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название одежды: {Name}, размер: {Size}, сезон: {Season}, стоимость: {Price} у.е.");
        }
       
    }
}