using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace First_MVC_App.Models
{
    public class Category
    {
        // data annotation
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="Display Order must be between 1 to 100!")]
        public string DisplyOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;   

    }
}
