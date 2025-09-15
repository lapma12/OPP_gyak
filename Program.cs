using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_gyak
{
    public class Szemely
    {
        private string _nev;
        private int _eletkor;

        public string Nev {
            get { return _nev; }
            set { _nev = value; } 
        }
        public int Eletkor
        {
            get { return _eletkor; }
            set
            {
                if(value > 0) 
                    _eletkor = value;
            }
        }

        public override string ToString()
        {
            return $"A személy neve {Nev} életkora: {Eletkor}";
        }

        //public Szemely(string Nev, int Eletkor)
        //{
        //    this.nev = Nev;
        //    this.eletkor = Eletkor;
        //}
        //public string Kiir()
        //{
        //    return $"Személy neve: {nev} és életkora: {eletkor}";
        //}
    }   
    public class Bankszamla
    {
        private int _egyenleg;

        public int Egyenleg
        {
            get { return _egyenleg; }
            set {
                if(value > 0)
                    _egyenleg = value;
                else
                    Console.WriteLine("Egyenleg nem lethet nulla4!");
            }
        }

        public int Betesz()
        {

        }
        public int Kivesz()
        {

        }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Szemely person = new Szemely("Ilona", 31);
            //Console.WriteLine(person.Kiir());
            Szemely szemely = new Szemely();
            szemely.Nev = "Kis Ilona";
            szemely.Eletkor = 33;
            Console.WriteLine(szemely);
            //Console.WriteLine($"Személy neve: {szemely.Nev} és {szemely.Eletkor} éves");
            Console.ReadKey();
        }
    }
}
