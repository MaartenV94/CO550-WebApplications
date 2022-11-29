using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConvertor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Amount { get; set; } 

        private const double RATE = 1.14;

 
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Maarten Vanderbeeken";
        }

        public void OnPost()
        {
            double result;

            if (!string.IsNullOrEmpty(Amount))
            {
                result = Convert.ToDouble(Amount) * RATE;
                ViewData["Convert"] = $"{Amount} GBP is {result.ToString("0.00")} EURO";
            }

            if (string.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Name is missing!";
                FullName = "Anonymous";
            }
            else
            {
                ViewData["Message"] = "Name is Registered!";
            }
        }
    }
}