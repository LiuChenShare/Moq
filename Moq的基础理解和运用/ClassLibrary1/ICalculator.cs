using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICalculator
    {
        int Add(int param1, int param2);
        int Subtract(int param1, int param2);
        int Multipy(int param1, int param2);
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        int Divide(int param1, int param2);
        /// <summary>
        /// 美元兑换成人民币
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        int ConvertUSDtoRMB(int unit);
    }
}
