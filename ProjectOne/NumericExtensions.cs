using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    internal static class NumericExtensions
    {
        public static int EvenNumbersSum(this int[] source)
        {
            ArgumentNullException.ThrowIfNull(source, nameof(source));

            return source.AsParallel()
                         .Where(static n => n % 2 == 0)
                         .Sum();
        }
    }
}
