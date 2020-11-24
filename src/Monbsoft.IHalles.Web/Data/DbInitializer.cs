using Monbsoft.IHalles.Shared;
using System.Linq;

namespace Monbsoft.IHalles.Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IHallesDbContext context)
        {
            if (context.IHalles.Any())
            {
                return;
            }

            var ihalles = new IHalle[]
            {
                new IHalle { 
                    Name = "Boutet Horticulture", 
                    Address = new Address {Line = "2 chemin du moulinot", PostalCode = "25320", City = "Busy"},
                    Location = new Location {},


                }
            };

            context.IHalles.AddRange(ihalles);
            context.SaveChanges();
        }
    }
}