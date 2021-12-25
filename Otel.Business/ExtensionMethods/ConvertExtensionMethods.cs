using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Business.ExtensionMethods
{
    public static class ConvertExtensionMethods
    {
        public static int ToInt32(this object o)
        {
            return Convert.ToInt32(o);
        }
    }
}
