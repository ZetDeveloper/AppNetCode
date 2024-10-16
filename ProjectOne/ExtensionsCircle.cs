using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public static class ExtensionsCircle
    {
        public static double Circumference(this Circle circle)
        {
            ArgumentNullException.ThrowIfNull(circle, nameof(circle));

            return circle.Calculate(static r => 2 * Math.PI * Math.Abs(r));
        }
    }
}
