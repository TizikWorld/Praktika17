using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Praktika17
{
    internal class WageAccount : Account
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
