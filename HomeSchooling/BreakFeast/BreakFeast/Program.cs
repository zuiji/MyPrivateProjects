using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BreakFeast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Coffie coffie = PoureCoffie();
            Task<Eggs> eggsTask = MakeEggs(2);
            Task<Bacon> baconTask = MakeBacon(4);
            Task<Toast> toastTask = Toast();
            await Task.WhenAll(eggsTask, baconTask, toastTask);

            ServedBreakFood(toastTask.Result, baconTask.Result, coffie, eggsTask.Result);
        }

        private static async Task<Toast> Toast()
        {
            Toast toast = await MakeToast();
            await ApplyButter(toast);
            await ApplyJam(toast);
            return toast;
        }

        public static Coffie PoureCoffie()
        {
            Console.WriteLine("Heller kaffe i koppen");
            Task.Delay(1000).Wait();
            Console.WriteLine("kaffe klar");
            Coffie coffie = new Coffie();
            coffie.IsInCup = true;
            return coffie;
        }

        public static async Task<Eggs> MakeEggs(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Steger æg");
            }

            await Task.Delay(2000);
            Console.WriteLine("æg klar");
            Eggs eggs = new Eggs();
            eggs.IsFried = true;
            return eggs;
        }

        public static async Task<Bacon> MakeBacon(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Steger bacon");
            }

            await Task.Delay(2000);

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Steger bacon på den anden side");
            }

            await Task.Delay(2000);
            Console.WriteLine("bacon Klar");
            Bacon bacon = new Bacon();
            bacon.IsFried = true;
            return bacon;

        }

        public static async Task<Toast> MakeToast()
        {
            Console.WriteLine("laver toast");
            await Task.Delay(3000);

            Console.WriteLine("toast klar");
            Toast toast = new Toast();
            toast.IsFried = true;
            return toast;
        }

        public static async Task ApplyButter(Toast toast)
        {
            Console.WriteLine("tilføjer smør på toast");
            toast.Buttered = true;
            await Task.Delay(500);
            Console.WriteLine("toast har nu smør");
            return;
        }

        public static async Task ApplyJam(Toast toast)
        {
            Console.WriteLine("tilføjer syltetøj på toast");
            toast.Jammed = true;
            await Task.Delay(500);
            Console.WriteLine("Toast har nu syltetøj på");
            return;

        }

        public static void ServedBreakFood(Toast toast, Bacon bacon, Coffie coffie, Eggs eggs)
        {
            if (toast.IsFried && toast.Jammed && toast.Buttered && coffie.IsInCup && eggs.IsFried && bacon.IsFried)
            {
                Console.WriteLine("morgenmad serveret");
            }
            else
            {
                Console.WriteLine("kunne ikke serveres noget er gået galt");

            }
        }
    }

    internal class Toast
    {
        public bool IsFried { get; set; }
        public bool Jammed { get; set; }
        public bool Buttered { get; set; }
    }

    internal class Bacon
    {
        public bool IsFried { get; set; }
    }

    internal class Eggs
    {
        public bool IsFried { get; set; }

    }

    public class Coffie
    {
        public bool IsInCup { get; set; }

    }
}
