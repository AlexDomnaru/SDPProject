using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Domain.Entities;
using Data.Persistence;

namespace Presentation.Items
{
    public class DbSeeder
    {
	    private readonly ContentDbContext _content;

	    public DbSeeder(ContentDbContext content)
	    {
		    _content = content;
	    }

	    public async Task SeedAsync()
	    {
		    _content.Database.EnsureCreated();
		    await AddToDatabase();
	    }

	    private async Task AddToDatabase()
	    {
		    var postcode = new Postcode
		    {
				Code = "NN16 0RZ",
				City = "Kettering",
				Addresses = new List<Address>
				{
					new Address
					{
						House = "5",
						Street = "Mill Road"
					},
					new Address
					{
						House = "7",
						Street = "Mill Road"
					},
					new Address
					{
						House = "9",
						Street = "Mill Road"
					},
					new Address
					{
						House = "11",
						Street = "Mill Road"
					},
					new Address
					{
						House = "13",
						Street = "Mill Road"
					},new Address
					{
						House = "15",
						Street = "Mill Road"
					},
					new Address
					{
						House = "17",
						Street = "Mill Road"
					},
					new Address
					{
						House = "19",
						Street = "Mill Road"
					},
					new Address
					{
						House = "19a",
						Street = "Mill Road"
					},
					new Address
					{
						House = "19b",
						Street = "Mill Road"
					},
					new Address
					{
						House = "21",
						Street = "Mill Road"
					},
					new Address
					{
						House = "23",
						Street = "Mill Road"
					},
					new Address
					{
						House = "25a",
						Street = "Mill Road"
					},
					new Address
					{
						House = "25b",
						Street = "Mill Road"
					}
				}
		    };
		    await _content.Postcodes.AddAsync(postcode);
	    }
    }
}
