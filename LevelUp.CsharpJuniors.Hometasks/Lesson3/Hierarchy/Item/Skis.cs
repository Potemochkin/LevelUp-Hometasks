using Lesson3.Interfaces;

namespace Lesson3.Hierarchy.Item
{
    internal sealed class Skis : Equipment, Information
    {
        public Skis(string name, string description, int idNumber, int nomenclature, int price) :
         base(name, description, idNumber, nomenclature)
        { Price = price;}

        public void PrintInfo()
        {
            Console.WriteLine($"Название оборудования: {Name}, идентификатор: {IdNumber}, тип: {Type}, стоимость: {Price} у.е.");
        }
        public override int Price { get; set; }
    }
}