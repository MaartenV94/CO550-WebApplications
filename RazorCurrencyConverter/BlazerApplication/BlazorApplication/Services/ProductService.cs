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
                Price = 1125,
                Photo ="https://www.ibanez.com/common/product_artist_file/file/p_region_MAR10_LMM_1P_01_sub_1.jpg"
            },
            new()
            {
                Id = 2,
                Name = "Ibanez EH10",
                Description = "The signature guitar of Erick Hansel from the band CHON.",
                Price = 1015,
                Photo ="https://www.ibanez.com/common/product_artist_file/file/p_region_EH10_TGM_1P_01_sub_1.jpg"
            },
            new()
            {
                Id = 3,
                Name = "Ibanez YY10",
                Description = "The signature guitar of Yvette Young from the band Covet.",
                Price = 975,
                Photo ="https://www.ibanez.com/common/product_artist_file/file/p_region_YY10_SGS_1P_01_sub_1.jpg"
            },
            new()
            {
                Id = 4,
                Name = "Ibanez THBB10",
                Description = "The signature guitar of Tim Henson from the band Polyphia.",
                Price = 1425,
                Photo ="https://www.ibanez.com/common/product_artist_file/file/p_region_THBB10_1P_01_sub_1.jpg"
            },
        };
	}
}

