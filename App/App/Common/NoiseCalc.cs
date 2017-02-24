using System;
using System.Collections.Generic;

namespace ESMonApp.Common
{
    public class NoiseCalc
    {
        public static double CalcNoise(List<double> list)
        {
            double ret = 0;
            
            foreach (var item in list)
            {
                ret += Math.Pow(10, item / 10);
            }
            
            ret /= list.Count;
            
            ret = 10 * Math.Log10(ret);
            
            return ret;
        }
    }
}
