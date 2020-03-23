using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Personne
    {
		private int id;

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private String nom;

		public String Nom
		{
			get { return nom; }
			set { nom = value; }
		}

		private String prenom;

		public String Prenom
		{
			get { return prenom; }
			set { prenom = value; }
		}

		private Role role;

		public virtual Role Role
		{
			get { return role; }
			set { role = value; }
		}

		private Guid guid;

		public Guid Guid
		{
			get { return guid; }
			set { guid = value; }
		}

	}
}