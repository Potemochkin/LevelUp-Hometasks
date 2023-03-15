namespace Lesson3.Hierarchy
{
    public abstract class Wear : StoreItem
    {
        public override string Type { get; set; }
        public override int Id { get; set; }
        public override string Nomenclature { get; set; }
        public abstract double Price { get; set; }
        public abstract int Size { get; set; }
        public abstract string? Season { get; set; }
        protected Wear(string name, string description, string nomenclature)
        { 
            Name = name;
            Description = description;
            Type = "Одежда"; 
            Id = new Random().Next(100);
            Nomenclature = nomenclature;
        }   
    }
}