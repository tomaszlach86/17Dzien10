﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaZawodnicy.Domain
{
    public class Zawodnik
    {
        public int Id_zawodnika { get; set; }
        public int? Id_trenera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public int? Wzrost { get; set; }
        public int? Waga { get; set; }

        public string TrenerImieNazwisko { get; set; }
        public string ImieNazwisko
        {
            get
            {
                return Nazwisko + " " + Imie.Substring(0, 1) + ".";
            }
        }

        public double BMI
        {
            get
            {
                if (Wzrost == null || Waga == null)
                    return 0;

                int a = ObliczeniePomocnicznie();

                return (int)Waga / Math.Pow((int)Wzrost / 100.0, 2);
            }
        }

        private int ObliczeniePomocnicznie()
        {
            int a = 5 + 6;
            return a;
        }

        //public string DataSformatowana
        //{
        //    get
        //    {
        //        if (DataUrodzenia != null)
        //            return ((DateTime)DataUrodzenia).ToString("yyyy-MM-dd");
        //        return null;
        //    }
        //}


        // znak zapytania przed wywolaniem metody dziala tak, 
        // ze metoda ta zostanie wywolana tylko wtedy gdy argument przed znakiem
        // zapytania jest rozny od null a gdy arguemnt jest rowny null
        // to zostanie zwrocowna domyslna wartosć dla danego typu 
        public string DataSformatowana => DataUrodzenia?.ToString("yyyy-MM-dd");

        public string Wiersz =>
                    $"{Id_zawodnika};{Id_trenera};{Imie};{Nazwisko};{Kraj};" +
                    $"{DataSformatowana};{Wzrost};{Waga}";

        public string DaneRaportowe =>
            $"{Imie} {Nazwisko} {Kraj} {DataSformatowana}";

    }
}
