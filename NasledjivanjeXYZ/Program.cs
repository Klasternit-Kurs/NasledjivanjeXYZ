using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NasledjivanjeXYZ
{
	class Program
	{
		static void Main(string[] args)
		{
			NekaKlasa nk = new NekaKlasa();
			//nk.MaliTest = "asdasd";
			Console.WriteLine(nk.MaliTest);
			Console.ReadKey();
			
		}
	}

	class NekaKlasa 
	{
		public string BrzProperty { get; set; } = "podrazumevana";

		private string _maliTest ="jhgjhgjhg"; //Polje
		public string MaliTest //Property
		{
			get
			{
				return _maliTest;
			}

			set
			{
				_maliTest = value;
			}
		}
	}

	class NekaKlasaJr : NekaKlasa
	{
		public void Foo()
		{
			MaliTest = "123";
		}
	}

	class Osoba
	{
		public string Ime;
		public string Prezime;
		public int KoeficijentZaPlatu = 18;

		public Osoba()
		{
			Console.WriteLine("Konstruktor za osobu :)");
		}
	}

	class Zaposlen : Osoba
	{
		public decimal Plata;
		public Zaposlen()
		{
			Plata = KoeficijentZaPlatu * 500;
			Console.WriteLine("Konstruktor za zaposlenog");
		}
	}
}
