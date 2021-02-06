using System.ComponentModel.DataAnnotations;

namespace Monbsoft.IHalles.Application.Entities
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Line { get; set; }

        [Required, MaxLength(50)]
        public string City { get; set; }

        [Required, MaxLength(20)]
        public string Region { get; set; }

        [Required, MaxLength(20)]
        public string PostalCode { get; set; }
    }
}
