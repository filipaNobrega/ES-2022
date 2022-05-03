using System.ComponentModel.DataAnnotations;

namespace ShoppingListLibrary.Models
{
    public class ListItemEditModel
    {
        [Required]
        [MaxLength(16)]
        public string? Title { get; set; }
    }
}
