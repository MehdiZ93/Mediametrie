using System;
namespace Mediametrie
{
	public class Container
	{
		int id;
		string Nom;
		int Etat;

		private void NewContainer()
		{
			id = 0;
			Nom = "";
			Etat = 0;
		}

		private void NewContainer(int i, string n, int e)
		{
			id = i;
			Nom = n;
			Etat = e;
		}

		private void SetId(int i)
		{
			id = i;
		}

		private void SetNom(string n)
		{
			Nom = n;
		}

		private void SetEtat(int e)
		{
			Etat = e;
		}

		private int GetId()
		{
			return id;
		}

		private string GetNom()
		{
			return Nom;
		}

		private int GetEtat()
		{
			return Etat;
		}
	}
}
