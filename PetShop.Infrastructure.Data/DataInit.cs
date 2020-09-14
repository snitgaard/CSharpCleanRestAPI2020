using PetShop.Core.DomainServices;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure.Data
{
    public class DataInit
    {
        private readonly IPetRepository _petRepository;
        private readonly IOwnerRepository _ownerRepository;


        public DataInit(IPetRepository petRepository, IOwnerRepository ownerRepository)
        {
            _petRepository = petRepository;
            _ownerRepository = ownerRepository;
        }

        public void InitData()
        {
            var pet1 = new Pet
            {
                Name = "Billy Joel",
                Type = "Dog",
                Color = "Golden",
                BirthDate = new DateTime(2018, 6, 10),
                Price = 100,
                SoldDate = new DateTime(2018, 7, 10),
                PreviousOwner = "Johnny Bravo"
            };
            var owner1 = new Owner
            {
                Name = "Michael Jackson",
                Address = "JohnnyBravo Street"
            };
            _petRepository.Create(pet1);
            _ownerRepository.Create(owner1);
        }
    }
}
