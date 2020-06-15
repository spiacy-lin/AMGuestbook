using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AMGuestbook.Models;


namespace AMGuestbook.Data
{
    public class AMGuestbookContext: DbContext
    {
        public AMGuestbookContext(DbContextOptions<AMGuestbookContext> options)
            : base(options)
        {
        }

        public DbSet<Guest> Guest { get; set; }
    }
}
