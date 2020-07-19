using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Extensions
{
    public static class StringExtensions
    {
        public static String ReplaceMultiple(this String initial, string[] series)
        {
            switch(series.Length % 2)
            {
                case 0:
                    for (int idx = 0; idx < series.Length; idx+=2)
                    {
                        initial = initial.Replace(series[idx], series[idx + 1]);
                    }
                    return initial;
                default:
                    throw new Exception("Array is not even.");
            }
        }
    }
}
