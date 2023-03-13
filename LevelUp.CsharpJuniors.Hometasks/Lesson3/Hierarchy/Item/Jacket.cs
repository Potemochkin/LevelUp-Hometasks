using Lesson3.Interfaces;

namespace Lesson3.Hierarchy.Item
{
    internal sealed class Jacket : Wear, Information
    {
        public Jacket(string name, string description, int idNumber, int nomenclature, int price, int size, string season) :
            base(name, description, idNumber, nomenclature)
        {
            Price = price;
            Size = size;
            Season = season;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название одежды: {Name}, размер: {Size}, сезон: {Season}, стоимость: {Price} у.е.");
        }
        public override int Price { get; set; }
        public override int Size { get; set; }
        public override string? Season { get; set; }
    }
}