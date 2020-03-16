using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Demo.Entities
{
    public class Personne : ICloneable
    {
		private String nom;
		private String prenom;

		public String Prenom
		{
			get { return prenom; }
			set { prenom = value; }
		}

		public String Nom
		{
			get { return nom; }
			set {
				value = value.ToUpper();
				nom = value; 
			}
		}

		public Personne()
		{

		}

		public Personne(String Nom, String Prenom)
		{
			this.Nom = Nom;
			this.Prenom = Prenom;
		}

		public override string ToString()
		{
			return base.ToString() + " Nom: "+ this.Nom + " Prenom: " + this.Prenom;
		}

		public object Clone()
		{
			Personne result = new Personne();
			result.Nom = this.Nom;
			result.Prenom = this.Prenom;

			return result;
		}
	}
}
