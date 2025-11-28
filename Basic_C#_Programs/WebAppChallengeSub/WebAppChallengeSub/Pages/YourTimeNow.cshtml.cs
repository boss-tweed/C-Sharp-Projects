using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppChallengeSub.Pages
{
    public class YourTimeNowModel : PageModel
    {
        public DateTime CurrentDateTime { get; private set; }

        public void OnGet()
        {
            //logic to display date and time on web page
            CurrentDateTime = DateTime.Now;
        }
    }
}
