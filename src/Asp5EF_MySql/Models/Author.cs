using System.ComponentModel.DataAnnotations;

namespace Asp5EF.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        
    }
}