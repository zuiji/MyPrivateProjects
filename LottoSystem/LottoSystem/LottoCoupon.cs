using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace LottoSystem
{
    class LottoCoupon
    {
        /// <summary>
    /// constructor 
    /// </summary>
    /// <param name="numbersOfRows">the number of rows (must be between 1 of 10 ) </param>
        public LottoCoupon(int numbersOfRows)
        {//check if coupon number of rows is greater then 10 and lower then 1
            if (numbersOfRows > 10 || numbersOfRows <1)
            {
                throw new ArgumentException("numbers of rows must be between 1 and 10 ");
            }
            Rows = new List<Row>(numbersOfRows);
            for (int i = 0; i < numbersOfRows; i++)
            {
                Rows.Add(new Row());
            }
        }


        /// <summary>
        /// check coupon for winning numbers
        /// </summary>
        /// <returns></returns>
        public List<int> WinnerChecker()
        {
            List<int> correctNumbers = new List<int>();
            foreach (Row row in Rows)
            {
                correctNumbers.Add(row.CheckRowForWins(Generator.ReturnWinnerNumbers()));
            }

            return correctNumbers;
        }

        /// <summary>
        /// property 
        /// </summary>
        private List<Row> Rows {get;}

        /// <summary>
        /// printing coupon
        /// </summary>
        public void PrintCoupon()
        {
            Console.WriteLine(this);
        }

        /// <summary>
        /// printing coupon with winner numbers highlighted
        /// </summary>
        public void PrintWinnerNumbers()
        {
            foreach (Row row in Rows)
            {
                Console.Write($"{(Rows.IndexOf(row) + 1).ToString().PadLeft(3)}.\t");
                row.printWinnerNumberString(Generator.ReturnWinnerNumbers());
                Console.WriteLine();
            }
        }

        /// <summary>
        /// creating a string to represent the coupon
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string returnstring = "";
            foreach (Row row in Rows)
            {
                returnstring += $"{(Rows.IndexOf(row) +1).ToString().PadLeft(3)}.\t{row}\n";
            }
            return returnstring;
        }
    }
}
