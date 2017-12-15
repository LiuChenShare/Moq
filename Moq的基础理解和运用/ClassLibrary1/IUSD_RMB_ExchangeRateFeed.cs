using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// 人民币美元汇率
    /// </summary>
    public interface IUSD_RMB_ExchangeRateFeed
    {
        int GetActualUSDValue();
    }
}
