using BlazorApplication.Models;
using System.Collections.Immutable;
namespace BlazorApplication.Services
{
	public class ProductService
	{
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                Id = 1,
                Name = "Ibanez MAR10",
                Description = "The signature guitar of Mario Camarena from the band CHON.",
                Price = 1125
            },
            new()
            {
                Id = 2,
                Name = "Ibanez EH10",
                Description = "The signature guitar of Erick Hansel from the band CHON.",
                Price = 1015
            },
            new()
            {
                Id = 3,
                Name = "Ibanez YY10",
                Description = "The signature guitar of Yvette Young from the band Covet.",
                Price = 975
            },
            new()
            {
                Id = 4,
                Name = "Ibanez THBB10",
                Description = "The signature guitar of Tim Henson from the band Polyphia.",
                Price = 1425
            },
        };
	}
}

