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
        public decimal Price { get; set; } //change for check//3rd /4th/branch/5th branch cmd in/5th branch cmd in

	//cr bracnh and marge
	//change file notepad
    }
    //change in cmdline in merge open in cmdline
   
}
