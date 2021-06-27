using Monbsoft.IHalles.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monbsoft.IHalles.Application.Models
{
    public class Halle : BaseEntity, IAggregateRoot
    {
        public Halle()
        {
        }

        [Required]
        public Address Address { get; set; } = new Address();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string CreatorId { get; set; }

        public string Description { get; set; }
        [Required]
        public Location Location { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Updated { get; set; }

    }
}
