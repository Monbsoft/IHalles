﻿using MediatR;
using Monbsoft.IHalles.Application.Interfaces;
using Monbsoft.IHalles.Application.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace Monbsoft.IHalles.Application.Commands
{
    public class CreateHalleCommand : IRequest<Halle>
    {
        public CreateHalleCommand()
        {
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City  { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string PostalCode { get; set; }
    }

    public class CreateHalleCommandHandler : IRequestHandler<CreateHalleCommand, Halle>
    {
        private readonly IHalleRepository _halleRepository;
        public CreateHalleCommandHandler(IHalleRepository halleRepository)
        {
            _halleRepository = halleRepository;
        }

        public Task<Halle> Handle(CreateHalleCommand request, CancellationToken cancellationToken)
        {
            return _halleRepository.AddAsync(new Halle
            {
                Name = request.Name,
                Address = new Address(request.Street, request.City, request.Region, request.PostalCode),
                Location = new Location(0,0)
            }); ;

        }
    }
}
