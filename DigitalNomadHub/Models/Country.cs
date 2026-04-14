using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DigitalNomadHub.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        [DisplayName("Country Name")]
        [MaxLength(30)]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Numbers are not allowed.")]
        public String Name { get; set; }
    }
}
