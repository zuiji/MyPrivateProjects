using System;
using System.Collections.Generic;
using System.Text;

namespace LottoSystem
{
    public static class Prize
    {
        public static int WinnerPrize(int correctNumber)
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

        public static string PrintOutPrize(List<int> correctNumber)
        {
            string text = "";
            int totalprize = 0;

            for (int index = 0; index < correctNumber.Count; index++)
            {
                int number = correctNumber[index];
                var prize = WinnerPrize(number);
                if (prize > 0)
                {
                    totalprize += prize;
                    text += $"Hurray you had {number} correct numbers on row {index+01} and did win {prize}kr.\n";
                }
            }
            if (totalprize > 0)
            {
                text += $"In total you won {totalprize}.";

            }
            else
            {
                text = "Unfortunately you won nothing.";
            }

            return text;
            
        }

    }
}
