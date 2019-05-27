using System;
using System.Collections.Generic;
using System.Text;

namespace LottoSystem
{
    class Property
    {

        public int drawnNumber { get; set; }

        #region Coupon

        public int CouponLines { get; set; }
        public int CouponAmount { get; set; }
        public int Coupon { get; set; }
        public int CouponPrice { get; set; }

        #endregion


        public int Prize { get; set; }

        public int Winner { get; set; }

    }
}
