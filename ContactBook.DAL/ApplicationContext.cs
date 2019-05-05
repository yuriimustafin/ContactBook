using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBook.DAL.Entities;

namespace ContactBook.DAL
{
    public class ApplicationContext: DbContext
    {
        public DbSet<ContactEntity> ContactEntities { get; set; }
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
