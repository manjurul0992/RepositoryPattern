using System.ComponentModel.DataAnnotations;

namespace RepositoryFaisal.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Item")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]

        public string Description { get; set; }
        public decimal Price { get; set; } 

	
    }
    //1st change
}
