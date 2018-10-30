using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebEdKeyVault.Pages
{
    public class AboutModel : PageModel
    {
        public AboutModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private readonly IConfiguration _configuration = null;

        public string Message { get; set; }

        public void OnGet()
        {
            Message = "My key val = " + _configuration["AppSecret"];
        }
    }
}
