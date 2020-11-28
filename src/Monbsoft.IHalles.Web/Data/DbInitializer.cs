using Monbsoft.IHalles.Shared;
using System.Linq;

namespace Monbsoft.IHalles.Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IHallesDbContext context)
        {
            if(context.Users.Any())
            {
                return;
            }
            var users = new HUser[]
            {
                new HUser
                {
                    Email = "admin@ihalles.com",
                    UserName = "admin"
                }
            };
            context.Users.AddRange(users);
            context.SaveChanges();

            if(context.Addresses.Any())
            {
                return;
            }
            var addresses = new Address[]
            {
                new Address
                {
                    Line = "12 Grande rue", 
                    PostalCode = "25200", 
                    City = "Montbéliard",
                    Region = "Franche-comté"
                }
            };
            context.Addresses.AddRange(addresses);
            context.SaveChanges();

            if (context.IHalles.Any())
            {
                return;
            }

            var ihalles = new IHalle[]
            {
                new IHalle {
                    Creator = users[0],
                    Name = "Marché Montbéliard",
                    Address = addresses[0],
                    Location = new Location
                    {
                        Latitude =  47.50652d,
                        Longitude  = 6.79631d
                    }                  
                }
            };

            context.IHalles.AddRange(ihalles);
            context.SaveChanges();
        }
    }
}