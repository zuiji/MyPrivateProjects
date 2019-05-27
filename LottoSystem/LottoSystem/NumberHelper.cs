using System;
using System.Collections.Generic;

namespace LottoSystem
{
    public static class NumberHelper
    {
        /// <summary>
        ///  Creating 7 numbers and adding them to list
        /// </summary>
        /// <returns></returns>
        public static List<int> Get7Numbers()
        {
            Random random = new Random();
            List<int> lottoList = new List<int>(7);

            while (lottoList.Count < 7)
            {
                int ran = random.Next(1, 48);
                if (lottoList.Contains(ran))
                {
                    continue;
                }
                lottoList.Add(ran);
            }

            return lottoList;
        }
    }
}