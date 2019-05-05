using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBook.Domain.DomainModels;

namespace ContactBook.Domain.Abstract.Services
{
    public interface IContactService
    {
        ContactModel GetContactById(Guid id);
        ContactModel CreateContact(ContactModel model);
    }
}
