using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1001_BookTracking.Models
{
   public class Category
{
    [Key]
    public string NameToken { get; set; }

    [ForeignKey("CategoryTypeEntity")]
    public string CategoryType { get; set; }
    public CategoryType CategoryTypeEntity { get; set; }
    public string Description { get; set; }
   
   // Navigation property for related books
   public ICollection<Book> Books { get; set; }
   }
}