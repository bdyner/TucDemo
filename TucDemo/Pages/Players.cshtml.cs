using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TucDemo.Pages
{
    public class PlayersModel : PageModel
    {
        public List<string> Players { get; set; }
        public void OnGet()
        {
            Players = new List<string>
            {
                "Wayne Gretzky",
                "Jaromir Jagr",
                "Dominik Hazek",
                "Mario Lemiuex",
                "Jacques Laperrière"
            };
        }
    }
}
