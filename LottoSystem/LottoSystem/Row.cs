using System;
using System.Collections.Generic;
using System.Linq;

namespace LottoSystem
{
    class Row
    {
        #region property
        
        /// <summary>
        /// full property
        /// </summary>
        private readonly List<int> _rowList;
        private List<int> rowList
        {
            get { return _rowList.OrderBy(i => i).ToList(); }
        } 
        #endregion


        /// <summary>
        /// constructor
        /// </summary>
        public Row()
        {
            _rowList = NumberHelper.Get7Numbers();
        }

        /// <summary>
        /// checking winner numbers in each row
        /// </summary>
        /// <param name="winnerNumbers"></param>
        /// <returns></returns>
        public int CheckRowForWins(List<int> winnerNumbers)
        { int correctNumber = 0;
            foreach (int l in rowList)
            {
                foreach (int c in winnerNumbers)
                {
                    if (l == c)
                    {
                        correctNumber++;
                        break;
                    }
                }
            }

            return correctNumber;
        }

        /// <summary>
        /// Printing row with winner numbers highlighted 
        /// </summary>
        /// <param name="WinnerNumbers"></param>
        public void printWinnerNumberString(List<int> WinnerNumbers)
        {
            string returnstring = "";
            foreach (int i in rowList)
            {
                if (i < 10)
                {
                    returnstring += 0;
                }
                returnstring += i + " ";

                if (WinnerNumbers.Contains(i))
                {
                    var color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(returnstring);
                    Console.ForegroundColor = color;
                }
                else
                {
                    Console.Write(returnstring);
                }

                returnstring = "";
            }
        }

        
        public override string ToString()
        {
            string returnstring = "";
            foreach (int i in rowList)
            {
                if (i <10)
                {// adding 0 in front of single char number.
                    returnstring += 0;
                }
                returnstring += i + " ";
            }
            return returnstring;
        }
    }
}