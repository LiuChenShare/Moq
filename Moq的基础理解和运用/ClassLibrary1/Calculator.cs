using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator : ICalculator
    {
        private IUSD_RMB_ExchangeRateFeed _feed;
        public Calculator(IUSD_RMB_ExchangeRateFeed feed)
        {
            this._feed = feed;
        }

        #region ICalculator Members
        public int Add(int param1, int param2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 美元兑换成人民币
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public int ConvertUSDtoRMB(int unit)
        {
            return unit * _feed.GetActualUSDValue();
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        public int Divide(int param1, int param2)
        {
            return param1 / param2;
        }

        public int Multipy(int param1, int param2)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
