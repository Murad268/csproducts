using System.ComponentModel.DataAnnotations;

namespace productsApp.Models
{
    public class Category
    {
        private static int _ID = 1;
        public int Id { get; private set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters.")]
        public string Title { get; set; }

        public Category()
        {
            this.Id = _ID++;
        }
    }
}
