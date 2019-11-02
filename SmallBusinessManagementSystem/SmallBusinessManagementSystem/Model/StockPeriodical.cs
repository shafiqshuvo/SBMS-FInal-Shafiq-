using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystem.Model
{
    public class StockPeriodical
    {
        public string productName { set; get; }
        public string productCategory { set; get; }
        public string startDate { set; get; }
        public string endDate { set; get; }


        public string ProductCode { set; get; }
        public string CategoryCode { set; get; }
        public string ExpiredDate { set; get; }
        public int Reorderlavel { set; get; }
        public int OpeningBalance { set; get; }
        public int In { set; get; }
        public int ClosingBalance { set; get; }
        public int Out { set; get; }
    }
}
