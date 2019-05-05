using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBook.DAL.Entities;
using ContactBook.Domain.DomainModels;

namespace ContactBook.CompositionRoot
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ContactEntity, ContactModel>();
        }
    }
}
