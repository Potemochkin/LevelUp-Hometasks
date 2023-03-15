using Lesson3.Interfaces;

namespace Lesson3.Hierarchy.Item
{
    internal sealed class Protein : Food, IHasShelfLife, Information
    {
        public override double Price { get; set; }
        public Protein(string name, string description, string nomenclature, double price) :
            base(name, description, nomenclature)
            { 
                Price = price;
            }

        public void PrintInfo()
        {
            Console.WriteLine($"Название продукта: {Name}, идентификатор: {Id}, тип: {Type}, стоимость: {Price} у.е.");
        }        
        public void PrintExpirationDate(DateTime expirationData)
        {
           if (expirationData < DateTime.Today)
                Console.WriteLine("Срок годности продукта вышел");
           else
                if (expirationData == DateTime.Today)
                Console.WriteLine("Срок годности кончается сегодня");
           else
            Console.WriteLine($"Срок годности продукта в норме. Использовать до: {expirationData.ToLongDateString()}");
        }
                
    }
}