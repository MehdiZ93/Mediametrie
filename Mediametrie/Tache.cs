using System;
namespace Mediametrie
{
	public class Tache
	{
		int id;
		int idContainer;
		string Nom;
		string Description;
		DateTime Date_de_creation;
		DateTime Date_de_fin;
		byte Priorite;
		bool Etat;

		private void NewTache()
		{
			id = 0;
			idContainer = 0;
			Nom = "";
			Description = "";
			Date_de_creation = DateTime.Now;
			Date_de_fin = DateTime.Now;
			Priorite = 0;
			Etat = true;
		}

		private void NewTache(int i, int ic, string n, string d, DateTime df, byte p, bool e)
		{
			id = i;
			idContainer = ic;
			Nom = n;
			Description = d;
			Date_de_creation = DateTime.Now;
			Date_de_fin = df;
			Priorite = p;
			Etat = e;
		}

		private void SetId(int i)
		{
			id = i;
		}

		private void SetIdContainer(int ic)
		{
			idContainer = ic;
		}

		private void SetNom(string n)
		{
			Nom = n;
		}

		private void SetDescription(string d)
		{
			Description = d;
		}

		private void SetDate_de_fin(DateTime df)
		{
			Date_de_fin = df;
		}

		private void SetDate_de_creation()
		{
			Date_de_creation = DateTime.Now;
		}

		private void SetPriorite(byte p)
		{
			Priorite = p;
		}

		private void SetEtat(bool e)
		{
			Etat = e;
		}

		private int GetId()
		{
			return id;
		}

		private int GetIdContainer()
		{
			return idContainer;
		}

		private string GetNom()
		{
			return Nom;
		}

		private string GetDescription()
		{
			return Description;
		}

		private DateTime GetDate_de_fin()
		{
			return Date_de_fin;
		}

		private DateTime GetDate_de_creation()
		{
			return Date_de_creation;
		}

		private byte GetPriorite()
		{
			return Priorite;
		}

		private bool GetEtat()
		{
			return Etat;
		}

	}
}
