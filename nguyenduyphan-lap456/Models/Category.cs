namespace nguyenduyphan_lap456.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [required]
        [stringlength(255)]
        public string Name { get; set; }
    }
}