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

        public DataInit(IPetRepository petRepository)
        {
            _petRepository = petRepository;
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
            _petRepository.Create(pet1);
        }
    }
}
