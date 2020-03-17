using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Demo.Utils
{
    public static class Extension
    {
        public static int Add(this int a, int b)
        {
            return a + b;
        }

        public static String Add(this String a, String b)
        {
            return a + b;
        }
    }
}
