using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public class ContentDbContext: DbContext
    {
	    public ContentDbContext(DbContextOptions<ContentDbContext> options) : base((DbContextOptions)options)
		{
		    
	    }

	    public DbSet<Data.Domain.Entities.Postcode> Postcodes { get; set; }
    }
}
