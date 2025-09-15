using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_gyak
{
    public class Szemely
    {
        private string nev;
        private int eletkor;

        public Szemely(string Nev, int Eletkor)
        {
            this.nev = Nev;
            this.eletkor = Eletkor;
        }
        public string Kiir()
        {
            return $"Személy neve: {nev} és életkora: {eletkor}";
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely("Ilona", 31);
            Console.WriteLine(person.Kiir());

            Console.ReadKey();
        }
    }
}
