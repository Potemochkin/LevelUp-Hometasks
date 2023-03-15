namespace Lesson3.Hierarchy
{
    public abstract class Equipment : StoreItem
    {
        public override string Type { get; set; }
        public override int Id { get; set; }
        public override string Nomenclature { get; set; }
        public abstract double Price { get; set; }
        protected Equipment(string name, string description, string nomenclature)
        { 
            Name = name;
            Description = description;
            Type = "Оборудование";
            Id = new Random().Next(100);
            Nomenclature = nomenclature;
        }        
    }
}