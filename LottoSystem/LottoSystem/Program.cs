using System;

namespace LottoSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator.DrawWinnerNumbers();
            LottoCoupon coupon = new LottoCoupon(10);
            coupon.printWinnerNumbers();
            Console.WriteLine(string.Join("\n",coupon.WinnerChecker()));

            

            //Console.WriteLine("Your coupon numbers:\n");
            //foreach (int c in couponArray)
            //{
            //    Console.WriteLine(c);
            //}

            //foreach (int  l in lottoArray)
            //{
            //    foreach (int c in couponArray)
            //    {
            //        if (l == c)
            //        {
            //            correctNumber++;
            //            break;
            //        }
            //    }
            //}
            //switch (correctNumber)
            //{
            //    case 3:
            //        prize = 125;
            //        break;
            //            case 4:
            //        prize = 250;
            //        break;
            //    case 5:
            //        prize = 1250;
            //        break;
            //    case 6:
            //        prize = 22500;
            //        break;
            //    case 7:
            //        prize = 6000000;
            //        break;
            //    default:
            //        Console.WriteLine("To bad you did not wit anything this week, Try again next week.");
            //        break;
            //}

            //if (prize > 0 )
            //{
            //    Console.WriteLine($"Hurray you had {correctNumber} correct numbers and did win {prize}kr.");
            //}


        }
    }
}
