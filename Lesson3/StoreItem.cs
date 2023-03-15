namespace Lesson3
{
    public abstract class StoreItem
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public abstract string Type { get; set; }
        public abstract string Nomenclature { get; set; }
        public abstract int Id { get; set; }
    }
}