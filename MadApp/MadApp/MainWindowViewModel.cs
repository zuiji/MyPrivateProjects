using DublicateFileFinder;
using MadApp.Annotations;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MadApp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private static readonly Random _random = new Random();
        private readonly List<Ret> _ugensRettter = new List<Ret>();
        private List<Ret> _alleRetter = new List<Ret>();
        private bool _enableButtonIndKøb;
        private string _fredag;
        private string _mandag;
        private string _onsdag;
        private string _tirsdag;
        private string _torsdag;

        public MainWindowViewModel()
        {
            _alleRetter = HentAlleRetter();
            Mandag = "test";
            Tirsdag = "test";
            Onsdag = "test";
            Torsdag = "test";
            Fredag = "test";
            LavIndKøbsListeCommand = new RelayCommand(LavIndKøbsListe);
            LavMadPlanButtonCommand = new RelayCommand(LavMadPlanButton);
        }

        public RelayCommand LavIndKøbsListeCommand { get; set; }
        public RelayCommand LavMadPlanButtonCommand { get; set; }

        public string Mandag
        {
            get => _mandag;
            set
            {


                _mandag = value;
                OnPropertyChanged();
            }
        }

        public string Tirsdag
        {
            get => _tirsdag;
            set
            {
                _tirsdag = value;
                OnPropertyChanged();
            }
        }

        public string Onsdag
        {
            get => _onsdag;
            set
            {
                _onsdag = value;
                OnPropertyChanged();
            }
        }

        public string Torsdag
        {
            get => _torsdag;
            set
            {
                _torsdag = value;
                OnPropertyChanged();
            }
        }

        public string Fredag
        {
            get => _fredag;
            set
            {
                _fredag = value;
                OnPropertyChanged();
            }
        }

        public bool EnableButtonIndKøb
        {
            get => _enableButtonIndKøb;
            set
            {
                _enableButtonIndKøb = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

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

            Ret indBagtKylling = new Ret("indbagt Kylling", new List<Ingrediens>());
            indBagtKylling.ingredinser.Add(new Ingrediens("Kalkunbryst", 100));
            indBagtKylling.ingredinser.Add(new Ingrediens("Helbladet spinat", 25));
            indBagtKylling.ingredinser.Add(new Ingrediens("Mozzarella", 15));
            indBagtKylling.ingredinser.Add(new Ingrediens("Kogt Skinke", 15));
            indBagtKylling.ingredinser.Add(new Ingrediens("Bacon", 12));
            indBagtKylling.ingredinser.Add(new Ingrediens("Champignoner", 15));
            indBagtKylling.ingredinser.Add(new Ingrediens("Kartofler", 15));
            localListe.Add(indBagtKylling);

            Ret pandekager = new Ret("Pandekager", new List<Ingrediens>());
            pandekager.ingredinser.Add(new Ingrediens("hvedemel", 10));
            pandekager.ingredinser.Add(new Ingrediens("Sukker", 10));
            pandekager.ingredinser.Add(new Ingrediens("vaniljesukker", 25));
            pandekager.ingredinser.Add(new Ingrediens("salt", 10));
            pandekager.ingredinser.Add(new Ingrediens("Mælk", 8));
            pandekager.ingredinser.Add(new Ingrediens("Æg", 20));
            pandekager.ingredinser.Add(new Ingrediens("Smør", 15));
            localListe.Add(pandekager);

            Ret lasagne = new Ret("Lasagne", new List<Ingrediens>());
            lasagne.ingredinser.Add(new Ingrediens("smør", 15));
            lasagne.ingredinser.Add(new Ingrediens("hakket oksekød", 15));
            lasagne.ingredinser.Add(new Ingrediens("Løg", 15));
            lasagne.ingredinser.Add(new Ingrediens("pasta Plader", 15));
            lasagne.ingredinser.Add(new Ingrediens("hakket tomat", 15));
            lasagne.ingredinser.Add(new Ingrediens("krøderriger", 15));
            lasagne.ingredinser.Add(new Ingrediens("Monasovs", 15));
            lasagne.ingredinser.Add(new Ingrediens("pizza topping", 15));
            localListe.Add(lasagne);


            Ret boiledChicken = new Ret("Stækt Kylling med Ris", new List<Ingrediens>());
            boiledChicken.ingredinser.Add(new Ingrediens("kylling", 50));
            boiledChicken.ingredinser.Add(new Ingrediens("Smør", 10));
            boiledChicken.ingredinser.Add(new Ingrediens("Ris", 5));
            localListe.Add(boiledChicken);

            Ret restedag = new Ret("Restedag", new List<Ingrediens>());
            restedag.ingredinser.Add(new Ingrediens("Spis dine raster", 15));
            localListe.Add(restedag);
            return localListe;
        }

        private void LavIndKøbsListe(object o)
        {
            double prisIAlt = 0;
            SaveFileDialog dialog = new SaveFileDialog {OverwritePrompt = true, DefaultExt = ".txt", Filter = "TekstFil|*.txt" };
           
            if (dialog.ShowDialog().GetValueOrDefault() && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                using (var writer = new StreamWriter(dialog.FileName))
                {
                    foreach (var ret in _ugensRettter)
                    {
                        writer.WriteLine("Ret: " + ret.navn);
                        foreach (var ingredinser in ret.ingredinser)
                        {
                            writer.WriteLine(ingredinser.navn);
                            writer.WriteLine(ingredinser.pris + " kr.");
                            prisIAlt += ingredinser.pris;
                        }

                        writer.WriteLine("--------------");
                    }
                    writer.WriteLine("Prisen for denne uges mad er: " + prisIAlt + "kr.");
                    MessageBox.Show("Din indkøbsliste er nu gemt");
                }

              
            }
            else
            {
                MessageBox.Show("Din indkøbsliste er ikke gemt");

            }

        }


        private void LavMadPlanButton(object o)
        {
            LavMadPlan();
            _alleRetter = HentAlleRetter();
            //ButtonInkøb.IsEnabled = true;
            EnableButtonIndKøb = true;
        }

        public void LavMadPlan()
        {
            var randomNumber = _random.Next(0, _alleRetter.Count);

            // Mandag
            //  Labelmandag.Content = _alleRetter[randomNumber].navn;
            Mandag = _alleRetter[randomNumber].navn;
            _ugensRettter.Add(_alleRetter[randomNumber]);
            _alleRetter.RemoveAt(randomNumber);

            // Tirsdag
            randomNumber = _random.Next(0, _alleRetter.Count);
            // Labeltirsdag.Content = _alleRetter[randomNumber].navn;
            Tirsdag = _alleRetter[randomNumber].navn;

            _ugensRettter.Add(_alleRetter[randomNumber]);
            _alleRetter.RemoveAt(randomNumber);

            // Onsdag
            randomNumber = _random.Next(0, _alleRetter.Count);
            //  Labelonsdag.Content = _alleRetter[randomNumber].navn;
            Onsdag = _alleRetter[randomNumber].navn;
            _ugensRettter.Add(_alleRetter[randomNumber]);
            _alleRetter.RemoveAt(randomNumber);

            // Torsdag
            randomNumber = _random.Next(0, _alleRetter.Count);
            // Labeltorsdag.Content = _alleRetter[randomNumber].navn;
            Torsdag = _alleRetter[randomNumber].navn;
            _ugensRettter.Add(_alleRetter[randomNumber]);
            _alleRetter.RemoveAt(randomNumber);

            // Fredag
            randomNumber = _random.Next(0, _alleRetter.Count);
            // Labelfredag.Content = _alleRetter[randomNumber].navn;
            Fredag = _alleRetter[randomNumber].navn;
            _ugensRettter.Add(_alleRetter[randomNumber]);
            _alleRetter.RemoveAt(randomNumber);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}