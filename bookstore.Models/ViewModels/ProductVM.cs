using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace bookstore.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        [ValidateNever]
        public IEnumerable<Category> CategoryList { get; set; }
    }
}
