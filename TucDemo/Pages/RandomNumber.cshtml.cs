using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TucDemo.Pages
{
    public class RandomNumberModel : PageModel
    {
      //  public static Random _rnd = new Random();
        public int RandomNumber {get; set; }
        public string Tid { get; set; }
        public void OnGet()
        {
            Random _rnd = new Random();
            Tid = DateTime.Now.ToString("HH:mm");
            RandomNumber = _rnd.Next(0, 300000);
        }
    }
}
