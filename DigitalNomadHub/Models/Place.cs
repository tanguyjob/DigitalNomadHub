using System.ComponentModel.DataAnnotations;

namespace DigitalNomadHub.Models
{
    public class Place
    {
        [Key]
        public int Place_Id { get; set; }
        [Required]
        public String Name { get; set; }
    }
}
