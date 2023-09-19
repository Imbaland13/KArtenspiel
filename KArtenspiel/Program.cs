using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartenspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13 Karten
            Karten karten = new Karten();
            Stack<Karten> kartenlistePik;
            kartenlistePik = karten.Kartengenerierung("Pik");
            Stack<Karten> kartenlisteHerz;
            kartenlisteHerz = karten.Kartengenerierung("Herz");           
            Stack<Karten> kartenlisteKaro;
            kartenlisteKaro = karten.Kartengenerierung("Karo");
            Stack<Karten> kartenlisteKreuz;
            kartenlisteKreuz = karten.Kartengenerierung("Kreuz");
            Stack<Karten> kartenlisteGemischt;
            Stack<Karten> kartenlisteGemischtAlle;
            //kartenlisteGemischt = karten.KartenMischen(kartenlisteHerz, kartenlistePik);
            //karten.Ausgabe(kartenlisteGemischt);
            Console.WriteLine("==================================" +
                "=============================================");
            //kartenlisteGemischtAlle = karten.KartenMischen(kartenlisteKreuz,
            //    kartenlisteKaro,kartenlisteHerz,kartenlistePik);
            //karten.Ausgabe(kartenlisteGemischtAlle);
            //karten.Ausgabe(kartenlistePik);
            Console.WriteLine();
            Stack<Karten> stack = karten.Abheben(kartenlistePik);
            karten.Ausgabe(stack);            
        }
    }
}

