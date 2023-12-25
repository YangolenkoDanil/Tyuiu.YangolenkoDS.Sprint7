using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.YangolenkoDS.Sprint7.Project.V1.Lib
{
    public class DataService
    {
        public int GetMaxValue(int[] array)
        {
            return array.Max();
        }
        public int GetMinValue(int[] array)
        {
            return array.Min();
        }
        public double GetAvgValue(int[] array)
        {
            double res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                res += array[i];
            }
            return Math.Round(res / array.Length, 3);
        }
    }
}
