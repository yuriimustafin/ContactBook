using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBook.Domain.Abstract.Services;
using ContactBook.Domain.DomainModels;
using ContactBook.DAL.Abstract;
using ContactBook.DAL.Entities;
using AutoMapper;

namespace ContactBook.Domain.Concrete.Services
{
    public class ContactService : IContactService
    {
        private readonly IGenericRepository<ContactEntity> _repository;
        private readonly IMapper _mapper;
        public ContactService(IGenericRepository<ContactEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ContactModel CreateContact(ContactModel model)
        {
            return _mapper.Map<ContactModel>(
                      _repository.Create(
                          _mapper.Map<ContactEntity>(model)));
        }

        public ContactModel GetContactById(Guid id)
        {
            return _mapper.Map<ContactModel>(_repository.GetById(id));
        }
    }
}
