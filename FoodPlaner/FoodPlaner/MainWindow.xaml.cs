using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodPlaner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ret> alleRetter = new List<Ret>();
        List<Ret> ugensRettter = new List<Ret>();
        static Random random = new Random();

        public MainWindow()
        {
            alleRetter = HentAlleRetter();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            LavMadPlan();
            alleRetter = HentAlleRetter();
            ButtonInkøb.IsEnabled = true;
        }

        public void LavMadPlan()
        {
            int randomNumber = random.Next(0, alleRetter.Count);

            // Mandag
            Labelmandag.Content = alleRetter[randomNumber].navn;
            ugensRettter.Add(alleRetter[randomNumber]);
            alleRetter.RemoveAt(randomNumber);

            // Tirsdag
            randomNumber = random.Next(0, alleRetter.Count);
            Labeltirsdag.Content = alleRetter[randomNumber].navn;
            ugensRettter.Add(alleRetter[randomNumber]);
            alleRetter.RemoveAt(randomNumber);

            // Onsdag
            randomNumber = random.Next(0, alleRetter.Count);
            Labelonsdag.Content = alleRetter[randomNumber].navn;
            ugensRettter.Add(alleRetter[randomNumber]);
            alleRetter.RemoveAt(randomNumber);

            // Torsdag
            randomNumber = random.Next(0, alleRetter.Count);
            Labeltorsdag.Content = alleRetter[randomNumber].navn;
            ugensRettter.Add(alleRetter[randomNumber]);
            alleRetter.RemoveAt(randomNumber);

            // Fredag
            randomNumber = random.Next(0, alleRetter.Count);
            Labelfredag.Content = alleRetter[randomNumber].navn;
            ugensRettter.Add(alleRetter[randomNumber]);
            alleRetter.RemoveAt(randomNumber);

        }

        private List<Ret> HentAlleRetter()
        {
            List<Ret> localListe = new List<Ret>();
            Ret bollerIKarry = new Ret("Boller I Karry", new List<Ingrediens>());
            bollerIKarry.ingredinser.Add(new Ingrediens("Ris", 5));
            bollerIKarry.ingredinser.Add(new Ingrediens("Karry", 10));
            bollerIKarry.ingredinser.Add(new Ingrediens("Kalv og Gris", 20));
            bollerIKarry.ingredinser.Add(new Ingrediens("salt", 10));
            bollerIKarry.ingredinser.Add(new Ingrediens("æg", 20));
            bollerIKarry.ingredinser.Add(new Ingrediens("hvedemel", 10));
            bollerIKarry.ingredinser.Add(new Ingrediens("mælk", 8));
            bollerIKarry.ingredinser.Add(new Ingrediens("løg", 15));
            bollerIKarry.ingredinser.Add(new Ingrediens("peber", 20));
            bollerIKarry.ingredinser.Add(new Ingrediens("smør", 10));
            bollerIKarry.ingredinser.Add(new Ingrediens("hvidløg", 5));
            bollerIKarry.ingredinser.Add(new Ingrediens("hønsefong", 20));
            localListe.Add(bollerIKarry);

            Ret IndBagtKylling = new Ret("indbagt Kylling", new List<Ingrediens>());
            IndBagtKylling.ingredinser.Add(new Ingrediens("Kalkunbryst", 100));
            IndBagtKylling.ingredinser.Add(new Ingrediens("Helbladet spinat", 25));
            IndBagtKylling.ingredinser.Add(new Ingrediens("Mozzarella", 15));
            IndBagtKylling.ingredinser.Add(new Ingrediens("Kogt Skinke", 15));
            IndBagtKylling.ingredinser.Add(new Ingrediens("Bacon", 12));
            IndBagtKylling.ingredinser.Add(new Ingrediens("Champignoner", 15));
            IndBagtKylling.ingredinser.Add(new Ingrediens("Kartofler", 15));
            localListe.Add(IndBagtKylling);

            Ret pandekager = new Ret("Pandekager", new List<Ingrediens>());
            pandekager.ingredinser.Add(new Ingrediens("hvedemel", 10));
            pandekager.ingredinser.Add(new Ingrediens("Sukker", 10));
            pandekager.ingredinser.Add(new Ingrediens("vaniljesukker", 25));
            pandekager.ingredinser.Add(new Ingrediens("salt", 10));
            pandekager.ingredinser.Add(new Ingrediens("Mælk", 8));
            pandekager.ingredinser.Add(new Ingrediens("Æg", 20));
            pandekager.ingredinser.Add(new Ingrediens("Smør", 15));
            localListe.Add(pandekager);

            Ret Lasagne = new Ret("Lasagne", new List<Ingrediens>());
            Lasagne.ingredinser.Add(new Ingrediens("smør", 15));
            Lasagne.ingredinser.Add(new Ingrediens("hakket oksekød", 15));
            Lasagne.ingredinser.Add(new Ingrediens("Løg", 15));
            Lasagne.ingredinser.Add(new Ingrediens("pasta Plader", 15));
            Lasagne.ingredinser.Add(new Ingrediens("hakket tomat", 15));
            Lasagne.ingredinser.Add(new Ingrediens("krøderriger", 15));
            Lasagne.ingredinser.Add(new Ingrediens("Monasovs", 15));
            Lasagne.ingredinser.Add(new Ingrediens("pizza topping", 15));
            localListe.Add(Lasagne);


            Ret boiledChicken = new Ret("Stækt Kylling med Ris", new List<Ingrediens>());
            boiledChicken.ingredinser.Add(new Ingrediens("kylling", 50));
            boiledChicken.ingredinser.Add(new Ingrediens("Smør", 10));
            boiledChicken.ingredinser.Add(new Ingrediens("Ris", 5));
            localListe.Add(boiledChicken);

            Ret Restedag = new Ret("Restedag", new List<Ingrediens>());
            Restedag.ingredinser.Add(new Ingrediens("Spis dine raster", 15));
            localListe.Add(Restedag);
            return localListe;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double PrisIAlt = 0;
            StreamWriter writer = new StreamWriter("indkøbtsliste.txt");
            foreach (Ret ret in ugensRettter)
            {
                writer.WriteLine("Ret: " + ret.navn);
                for (int i = 0; i < ret.ingredinser.Count; i++)
                {
                    writer.WriteLine(ret.ingredinser[i].navn);
                    writer.WriteLine(ret.ingredinser[i].pris + " kr.");
                    PrisIAlt += ret.ingredinser[i].pris;
                }

                writer.WriteLine("--------------");
            }

            writer.WriteLine("Prisen for denne uges mad er: " + PrisIAlt + "kr.");
            writer.Close();
        }
    }

    class Ret
    {
        public string navn;
        public List<Ingrediens> ingredinser;

        public Ret(string __navn, List<Ingrediens> _ingredinser)
        {
            navn = __navn;
            ingredinser = _ingredinser;


        }
    }

    class Ingrediens
    {
        public string navn;
        public double pris;

        public Ingrediens(string _navn, double _pris)
        {
            navn = _navn;
            pris = _pris;
        }
    }


}

