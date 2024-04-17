using bookstore.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bookstore.Models
{
    public class Category : BaseModel
    {

        [Required]
        [MaxLength(30, ErrorMessage = "Maximum length should not be more than 30")]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="Display Order Must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
