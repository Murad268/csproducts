using System.ComponentModel.DataAnnotations;

namespace productsApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters.")]
        public string Title { get; set; }
    }
}
