using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TucDemo.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string CurrentWeekDay { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
       
        public void OnGet()
        {
            var svenska = new CultureInfo("sv-SE");
            CurrentWeekDay = DateTime.Now.ToString("dddd", svenska);
        
        }
    }
}
