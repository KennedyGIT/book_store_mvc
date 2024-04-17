using System.ComponentModel.DataAnnotations;

namespace bookstore.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
