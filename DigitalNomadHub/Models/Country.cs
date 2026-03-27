using System.ComponentModel.DataAnnotations;

namespace DigitalNomadHub.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public String Name { get; set; }
    }
}
