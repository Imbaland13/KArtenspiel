using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kartenspiel
{
    internal class Karten
    {
        string Farbe { get; set; }
        int Wert { get; set; }
        string Name { get; set; }
        public Stack<Karten> Kartengenerierung(string farbe)
        {
            Stack<Karten> kartenliste = new Stack<Karten>();
            for (int i = 1; i < 14; i++)
            {
                if (i == 1)
                {
                    Karten karten = new Karten() { Wert = 14, Farbe = farbe, Name = "As" };
                    kartenliste.Push(karten);
                }
                else if (i == 11)
                {
                    Karten bube = new Karten() { Wert = 11, Farbe = farbe, Name = "Bube" };
                    kartenliste.Push(bube);
                }
                else if (i == 12)
                {
                    Karten Dame = new Karten() { Wert = 12, Farbe = farbe, Name = "Dame" };
                    kartenliste.Push(Dame);
                }
                else if (i == 13)
                {
                    Karten König = new Karten() { Wert = 13, Farbe = farbe, Name = "König" };
                    kartenliste.Push(König);
                }
                else
                {
                    Karten karten1 = new Karten() { Wert = i, Farbe = farbe };
                    kartenliste.Push(karten1);
                }
            }
            return kartenliste;
        }
        public Stack<Karten> KartenMischen(Stack<Karten> stack, Stack<Karten> stack2)
        {
            Stack<Karten> gemischteKarten = new Stack<Karten>();
            while (stack.Count > 0)
            {
                while (stack2.Count > 0)
                {
                    gemischteKarten.Push(stack.Pop());
                    gemischteKarten.Push(stack2.Pop());
                }
            }
            return gemischteKarten;
        }
        public Stack<Karten> KartenMischen(Stack<Karten> stack,
            Stack<Karten> stack2, Stack<Karten> stack3)
        {
            Stack<Karten> gemischteKarten = new Stack<Karten>();
            while (stack.Count > 0)
            {
                while (stack2.Count > 0)
                {
                    gemischteKarten.Push(stack.Pop());
                    gemischteKarten.Push(stack2.Pop());
                    gemischteKarten.Push(stack3.Pop());
                }
            }
            return gemischteKarten;
        }
        public Stack<Karten> KartenMischen(Stack<Karten> stack,
            Stack<Karten> stack2, Stack<Karten> stack3, Stack<Karten> stack4)
        {
            Stack<Karten> gemischteKarten = new Stack<Karten>();
            while (stack.Count > 0)
            {
                while (stack2.Count > 0)
                {
                    gemischteKarten.Push(stack.Pop());
                    gemischteKarten.Push(stack2.Pop());
                    gemischteKarten.Push(stack3.Pop());
                    gemischteKarten.Push(stack4.Pop());
                }
            }
            return gemischteKarten;
        }
        public Stack<Karten> Abheben(Stack<Karten> stack)
        {
            Stack<Karten> neuerstapel = new Stack<Karten>();
            Stack<Karten> neuerstapel1 = new Stack<Karten>();
            Stack<Karten> neuerstapel2 = new Stack<Karten>();
            Stack<Karten> neuerstapel3 = new Stack<Karten>();
            Stack<Karten> neusortierterstapel = new Stack<Karten>();

            for (int j = 0; j <= (stack.Count / 4); j++)
            {
                neuerstapel.Push(stack.Pop());
            }
            for(int i = 0; i <= (stack.Count / 4); i++)
            {
                neuerstapel1.Push(stack.Pop());
            }
            for(int i = 0; i <= (stack.Count / 4); i++)
            {
                neuerstapel2.Push(stack.Pop());
            }
            for(int i = 0; i <= (stack.Count / 4); i++)
            {
                neuerstapel3.Push(stack.Pop());
            }
            while (neuerstapel.Count > 0)neusortierterstapel.Push(neuerstapel.Pop());
            while (neuerstapel2.Count > 0)neusortierterstapel.Push(neuerstapel2.Pop());
            while (neuerstapel1.Count > 0)neusortierterstapel.Push(neuerstapel1.Pop());
            while (neuerstapel3.Count > 0)neusortierterstapel.Push(neuerstapel3.Pop());
            while (neuerstapel.Count > 0) neusortierterstapel.Push(neuerstapel.Pop());
            while (stack.Count > 0) neusortierterstapel.Push(stack.Pop());
            return neusortierterstapel;
        }
        public List<Stack<Karten>> Abheben(Stack<Karten> stack, int anzahlstacks)
        {
            List<Stack<Karten>> stackliste = new List<Stack<Karten>>();
            Stack<Karten> stack1 = new Stack<Karten>();
            for(int i = 0; i <= (stack.Count / 2); i++)
            {
                stack1.Push(stack.Pop());
            }
            stackliste.Add(stack1);
            stackliste.Add(stack);
            return stackliste;
        }
        public void Ausgabe(Stack<Karten> stack)
        {
            foreach (Karten karte in stack)
            {
                Console.Write(karte.Wert + " " + karte.Farbe + " " + karte.Name);
                Console.WriteLine();
            }
        }
        public void Ausgabe(List<Stack<Karten>> liststack)
        {
            foreach(var stack in liststack)
            {
                foreach(Karten karte in stack) 
                {
                    Console.WriteLine(karte);
                }
            }
        }
    }
}
