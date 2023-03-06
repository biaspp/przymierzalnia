using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace OSTATECZNEGUI
{
    internal class Projektowanie
    {
        public class Ubranie
        {
            protected string Nazwa { get; set; }
            protected string Rozmiar { get; set; }
            protected string Kolor { get; set; }
            protected string Material { get; set; }


            public Ubranie(string nazwa, string rozmiar, string kolor, string material)
            {
                Nazwa = nazwa;
                Rozmiar = rozmiar;
                Kolor = kolor;
                Material = material;

            }

            public virtual void WyswietlInformacje()
            {
                Console.WriteLine($"Nazwa: {Nazwa}\nRozmiar: {Rozmiar}\nKolor: {Kolor}\nMaterial: {Material}\n");
            }
            public virtual void Przymierz()
            {
                Console.WriteLine($"Przymierzam {Nazwa} w rozmiarze {Rozmiar}.");
            }
        }

        public class Koszulka : Ubranie
        {
            private bool DlugiRękaw { get; set; }
            private TextBox textBox;

            public Koszulka(string nazwa, string rozmiar, string kolor, string material, bool dlugiRekaw, TextBox textBox)
                : base(nazwa, rozmiar, kolor, material)
            {

                DlugiRękaw = dlugiRekaw;
                this.textBox = textBox;
            }

            public override void Przymierz()
            {
                base.Przymierz();
                textBox.Text = $"Koszulka {Nazwa} w rozmiarze {Rozmiar} jest {Kolor} i wykonana z {Material}. {(DlugiRękaw ? "Jest" : "Nie jest")} na dlugi rekaw.";
            }

            public void ZakladajPodkoszulek()
            {
                Console.WriteLine($"Zakładam podkoszulek pod {Nazwa}.");
            }
        }
        public class Spodnie : Ubranie
        {
            private string Kroj { get; set; }
            private bool Kieszenie { get; set; }
            private TextBox textBox;

            public Spodnie(string nazwa, string rozmiar, string kolor, string material, string kroj, bool kieszenie, TextBox textBox)
                : base(nazwa, rozmiar, kolor, material)
            {
                Kroj = kroj;
                Kieszenie = kieszenie;
                this.textBox = textBox;
            }

            public override void Przymierz()
            {
                base.Przymierz();
                textBox.Text = $"Spodnie {Nazwa} w kroju {Kroj} {Rozmiar} sa {Kolor} i wykonane z {Material}. Maja {(Kieszenie ? "kieszenie." : "brak kieszeni.")}";
            }


        }

        public class Sukienka : Ubranie
        {
            private string Wzor { get; set; }
            private string Dlugosc { get; set; }
            private bool Dekolt { get; set; }
            private TextBox textBox;

            public Sukienka(string nazwa, string rozmiar, string kolor, string material, string wzor, string dlugosc, bool dekolt, TextBox textBox)
                : base(nazwa, rozmiar, kolor, material)
            {
                Wzor = wzor;
                Dlugosc = dlugosc;
                Dekolt = dekolt;
                this.textBox = textBox;
            }

            public override void Przymierz()
            {
                base.Przymierz();
                textBox.Text = $"Sukienka {Nazwa} we wzorze {Wzor} o dlugosci {Dlugosc} jest {Kolor} i wykonana z {Material}. {(Dekolt ? "Ma dekolt" : "Nie ma dekoltu")} .";
            }


        }

        public class Buty : Ubranie
        {
            private TextBox textBox;
            public Buty(string nazwa, string rozmiar, string kolor, string material, TextBox textBox)
                : base(nazwa, rozmiar, kolor, material)
            {
                this.textBox = textBox;
            }
            public override void Przymierz()
            {
                base.Przymierz();
                textBox.Text = $"Buty {Nazwa} w rozmiarze {Rozmiar} sa {Kolor} i wykonane z {Material}.";
            }

            public void ZakladajSkarpety()
            {
                Console.WriteLine($"Zakladam skarpety do butow {Nazwa} w rozmiarze {Rozmiar}.");
            }
        }
        public class Bluza : Ubranie
        {
            private TextBox textBox;
            private Koszulka Podkoszulek { get; set; }
            private bool Kaptur { get; set; }

            public Bluza(string nazwa, string rozmiar, string kolor, string material, Koszulka podkoszulek, bool kaptur, TextBox textBox)
                : base(nazwa, rozmiar, kolor, material)
            {
                Podkoszulek = podkoszulek;
                Kaptur = kaptur;
                this.textBox = textBox;
            }

            public override void Przymierz()
            {
                base.Przymierz();
                textBox.Text = $"Bluza {Nazwa} w rozmiarze {Rozmiar} jest {Kolor} i wykonana z {Material}. {(Kaptur ? "Ma kaptur" : "Nie ma kaptura")} .";
                
            }

            public void ZakladajPodkoszulek()
            {
                Podkoszulek.ZakladajPodkoszulek();
            }
        }


        public class Projekt
        {
            private List<Ubranie> ubrania;

            public Projekt(List<Ubranie> ubrania)
            {
                this.ubrania = ubrania;
            }

            public void ZalozUbranie(Ubranie ubranie)
            {
                ubrania.Add(ubranie);
                Console.WriteLine("Zalozono ubranie:\n" + ubranie.ToString());
            }

            public void WyswietlUbrania()
            {
                Console.WriteLine("Ubrania w projekcie:");
                foreach (Ubranie ubranie in ubrania)
                {
                    Console.WriteLine(ubranie.ToString());
                }
            }

            public void PrzeniesUbranie(Projekt innyProjekt, Ubranie ubranie)
            {
                if (ubrania.Contains(ubranie))
                {
                    ubrania.Remove(ubranie);
                    Console.WriteLine("Przeniesiono ubranie:\n" + ubranie.ToString() + "\nz projektu " + ToString() + " do projektu " + innyProjekt.ToString() + ".");
                    innyProjekt.ZalozUbranie(ubranie);
                }
                else
                {
                    Console.WriteLine("Ubranie nie znajduje sie w tym projekcie.");
                }
            }
        }
        //static void Main(string[] args)
        //{
        //    Koszulka podkoszulek = new Koszulka("Podkoszulek", "M", "Biały", "Bawełna", false);
        //    Bluza bluza = new Bluza("Bluza z kapturem", "L", "Czarna", "Bawełna", podkoszulek, true);
        //    Spodnie spodnie = new Spodnie("Spodnie", "M", "Niebieski", "Denim", "Straight", true);
        //    Sukienka sukienka = new Sukienka("Sukienka", "M", "Różowa", "Jedwab", "Gładka", "Za kolano", false);
        //    Buty trampki = new Buty("Trampki", "37", "Biały", "Skóra");
        //    Buty obcasy = new Buty("Obcasy", "37", "Czarny", "Skóra");

        //    List<Ubranie> codzienne = new List<Ubranie>();
        //    Projekt stroj_codzienny = new Projekt(codzienne);
        //    stroj_codzienny.ZalozUbranie(bluza);
        //    stroj_codzienny.ZalozUbranie(podkoszulek);
        //    stroj_codzienny.ZalozUbranie(spodnie);
        //    stroj_codzienny.ZalozUbranie(trampki);
        //    stroj_codzienny.WyswietlUbrania();

        //    List<Ubranie> wizytowe = new List<Ubranie>();
        //    Projekt stroj_wizytowy = new Projekt(wizytowe);
        //    stroj_wizytowy.ZalozUbranie(sukienka);
        //    stroj_wizytowy.ZalozUbranie(obcasy);
        //    stroj_wizytowy.WyswietlUbrania();

        //    stroj_codzienny.PrzeniesUbranie(stroj_wizytowy, bluza);
        //    stroj_codzienny.WyswietlUbrania();
        //}
    }
}
