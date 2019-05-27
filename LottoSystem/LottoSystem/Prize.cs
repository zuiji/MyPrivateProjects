using System;
using System.Collections.Generic;
using System.Text;

namespace LottoSystem
{
    public static class Prize
    {
        public static int WinnerPrize(List<int> correctNumber)
        {
            int prize = 0;
            switch (correctNumber)
            {
                case 3:
                    prize = 125;
                    break;
                case 4:
                    prize = 2500;
                    break;
                case 5:
                    prize = 25000;
                    break;
                case 6:
                    prize = 125000;
                    break;
                case 7:
                    prize = 6000000;
                    break;

            }

            return prize;


        }

        public static string PrintOutPrize(List<int> correctNumber, int prize)
        {
            string text = "";

            if (prize > 0)
            {
                text = $"Hurray you had {correctNumber} correct numbers and did win {prize}kr.";
            }

            return text;
        }

    }
}
