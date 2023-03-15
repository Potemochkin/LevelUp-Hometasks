using Lesson3.Interfaces;

namespace Lesson3.Hierarchy.Item
{
    internal sealed class Skis : Equipment, Information
    {
        public override double Price { get; set; }
        public Skis(string name, string description, string nomenclature, double price) :
         base(name, description, nomenclature)
        { 
            Price = price;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название оборудования: {Name}, идентификатор: {Id}, тип: {Type}, стоимость: {Price} у.е.");
        }
        
    }
}