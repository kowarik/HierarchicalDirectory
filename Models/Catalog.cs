using System.ComponentModel.DataAnnotations;

namespace HierarchicalDirectory.Models
{
    public class Catalog
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public Catalog Parent { get; set; }
        public IEnumerable<Catalog> Children { get; set; }
    }
}
