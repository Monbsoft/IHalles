using Monbsoft.IHalles.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monbsoft.IHalles.Application.Models
{
    public class IHalle : BaseEntity, IAggregateRoot
    {
        public IHalle(string name, Address address, string description, Location location)
        {
            Name = Check.NotNullOrEmpty(name, nameof(name));
            Address = Check.NotNull(address, nameof(address));           
            Description = Check.NotNullOrEmpty(description, nameof(description));
            Location = Check.NotNull(location, nameof(location));
        }

        private IHalle()
        {

        }

        [Required]
        public Address Address { get; private set; } = new Address();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; private set; } = DateTime.UtcNow;
        public string CreatorId { get; private set; }

        public string Description { get; private set; }
        [Required]
        public Location Location { get; private set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; private set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Updated { get; private set; }

    }
}
