using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_gyak
{
    public class Szemely
    {
        protected string _nev;
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
            set
            {
                if (value > 0)
                    _egyenleg = value;
                else
                    Console.WriteLine("Egyenleg nem lethet nulla!!");
            }
        }

        //public int Betesz()
        //{

        //}
        //public int Kivesz()
        //{

        //}
    }
    public class Hallgato : Szemely
    {
        private string _neptunKod;

        public string Neptunkod{
            get { return _neptunKod; }
            set
            {
                if (value.Length <= 6)
                    _neptunKod = value;
                else
                    Console.WriteLine("A neptunkód nem lehet hosszabb 6 karakternél.");
            }
        }
        public override string ToString()
        {
            return $"A hallgató neve {_nev}.";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Szemely person = new Szemely("Ilona", 31);
            //Console.WriteLine(person.Kiir());

            Szemely szemely = new Szemely();
            szemely.Nev = "Kis János";
            szemely.Eletkor = 33;
            Console.WriteLine(szemely);


            Hallgato student1 = new Hallgato();
            student1.Nev = "Gábor";
            Console.WriteLine(student1);

            List<Hallgato> studentList = new List<Hallgato>();
            for (int i = 0; i < 3; i++)
            {
                Hallgato student2 = new Hallgato();
                Console.Write($"Kérem a(z) {i + 1} hallgató nevét: ");
                student2.Nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát: ");
                student2.Eletkor = int.Parse(Console.ReadLine());
                studentList.Add(student2);
            }

            foreach (var item in studentList)
            {
                Console.WriteLine(item.Nev);
            }
            //Console.WriteLine($"Személy neve: {szemely.Nev} és {szemely.Eletkor} éves");
            Console.ReadKey();
        }
    }
}
