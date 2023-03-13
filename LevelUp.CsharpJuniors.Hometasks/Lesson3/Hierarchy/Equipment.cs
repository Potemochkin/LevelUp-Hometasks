namespace Lesson3.Hierarchy
{
    public abstract class Equipment : StoreItem
    {
        protected Equipment(string name, string description, int idNumber, int nomenclature)
        { Name = name; Description = description; Type = "Оборудование"; IdNumber = idNumber; Nomenclature = nomenclature; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string Type { get; set; }
        public override int IdNumber { get; set; }
        public override int Nomenclature { get; set; }
        public abstract int Price { get; set; }
    }
}