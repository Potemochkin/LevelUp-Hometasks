using Lesson3.Interfaces;

namespace Lesson3.Hierarchy.Item
{
    internal sealed class Protein : Food, IHasShelfLife, Information
    {
        public Protein(string name, string description, int idNumber, int nomenclature, int price) :
            base(name, description, idNumber, nomenclature)
            { Price = price;}

        public void PrintInfo()
        {
            Console.WriteLine($"Название продукта: {Name}, идентификатор: {IdNumber}, тип: {Type}, стоимость: {Price} у.е.");
        }        
        public void ExpirationDate(DateTime expirationData)
        {
           if (expirationData < DateTime.Today)
                Console.WriteLine("Срок годности продукта вышел");
           else
                if (expirationData == DateTime.Today)
                Console.WriteLine("Срок годности кончается сегодня");
           else
            Console.WriteLine($"Срок годности продукта в норме. Использовать до: {expirationData.ToLongDateString()}");
        }
        public override int Price { get; set; }        
    }
}