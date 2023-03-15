namespace Lesson3.Hierarchy
{
    public abstract class Food : StoreItem
    {
        public override string Type { get; set; }
        public override int Id { get; set; }
        public override string Nomenclature { get; set; }
        public abstract double Price { get; set; }
        protected Food(string name, string description, string nomenclature)
        {
            Name = name;
            Description = description;
            Type = "Еда";
            Id = new Random().Next(100);
            Nomenclature = nomenclature;
        }        
    }
}