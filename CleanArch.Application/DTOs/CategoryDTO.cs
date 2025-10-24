using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        //data annotations
        [Required(ErrorMessage = "Category name is required")]
        [MinLength(3, ErrorMessage = "Category name must be at least 3 characters long")]
        [MaxLength(100, ErrorMessage = "Category name must not exceed 100 characters")]
        public string Name { get; set; }
    }
}
