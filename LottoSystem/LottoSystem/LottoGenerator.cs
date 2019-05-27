using System;
using System.Collections.Generic;
using System.Text;

namespace LottoSystem
{
    public static class Generator
    {
        private static List<int> _winnerNumbers = new List<int>();


        /// <summary>
        /// Drawing 7 winner numbers
        /// </summary>
        public static void DrawWinnerNumbers()
        {
            _winnerNumbers = NumberHelper.Get7Numbers();
            
        }


        /// <summary>
        /// returning a new list of winner numbers
        /// </summary>
        /// <returns></returns>
        public static List<int> ReturnWinnerNumbers()
        {
            return new List<int>(_winnerNumbers);
        }
    }
}
