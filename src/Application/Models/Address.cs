using Monbsoft.IHalles.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;

namespace Monbsoft.IHalles.Application.Models
{
    public record Address
    {
        public Address(string street, string city, string region, string postalCode)
        {
            Street = Check.NotNullOrEmpty(street, nameof(street));
            City = Check.NotNullOrEmpty(city, nameof(city));
            Region = Check.NotNullOrEmpty(region, nameof(region));
            PostalCode = Check.NotNullOrEmpty(postalCode, nameof(postalCode));
        }

        public Address() { }

        [Required, MaxLength(50)]
        public string City { get; private set; }
        [Required, MaxLength(20)]
        public string PostalCode { get; private set; }
        [Required, MaxLength(20)]
        public string Region { get; private set; }
        [Required, MaxLength(100)]
        public string Street { get; private set; }
    }
}
