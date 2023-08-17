using System.ComponentModel.DataAnnotations;
namespace Web1001_BookTracking.Models

{
    public class CategoryType
{
    [Key]
    public string Type { get; set; }
    public string Name { get; set; }

    // Navigation property for related categories
    public ICollection<Category> Categories { get; set; }
}
}