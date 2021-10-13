using System;
using System.Collections.Generic;

namespace PDF_Portal_Azure_AD.Models
{
    public class CurrentUser // Holds the current user details
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> Claims { get; set; }
    }
}
