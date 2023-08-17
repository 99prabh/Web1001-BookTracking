using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1001_BookTracking.Models
{
    public class Book
{
    [Key]
    public string ISBN { get; set; }
    public string Title { get; set; }

    [ForeignKey("Category")]
    public string Category_NameToken { get; set; }
    public Category Category { get; set; }
    public string Author { get; set; }
}
}
