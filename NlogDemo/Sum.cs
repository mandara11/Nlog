using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    public class Sum
    {
        Nlog nlog = new Nlog();
        public void Addition( int a, int b)
        {
            if(a == 0 || b == 0)
            {
                nlog.LogDebugMode("The Program executing");
                nlog.LogError("A and B value are 0");
            }
            else
            {
                int c = a + b;
                nlog.LogDebugMode("The Program executing");
                nlog.LogInformation("The values added, Result:" + " " +c);
            }
        }
    }
}
