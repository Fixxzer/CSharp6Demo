using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Demo
{
    public class AutoPropertyInitializersOld
    {
        public AutoPropertyInitializersOld()
        {
            Ints = new List<int>();

            TimeStamp = DateTime.UtcNow;
            User = System.Security.Claims.ClaimsPrincipal.Current.Identity.Name;
            Process = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        }

        public DateTime TimeStamp { get; set; }
        public string User { get; set; }
        public string Process { get; set; }

        public List<int> Ints { get; set; }
    }

    public class AutoPropertyInitializersNew
    {
        public DateTime TimeStamp { get; } = DateTime.UtcNow;
        public string User { get; } = System.Security.Claims.ClaimsPrincipal.Current.Identity.Name;
        public string Process { get; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
    }
}
