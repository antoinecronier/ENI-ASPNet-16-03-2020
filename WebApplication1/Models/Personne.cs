using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TPModule5_2_BO;

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

		[Required]
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

		private List<Pate> pates;

		public virtual List<Pate> Pates
		{
			get { return pates; }
			set { pates = value; }
		}

		private List<Pizza> pizzas;

		public List<Pizza> Pizzas
		{
			get { return pizzas; }
			set { pizzas = value; }
		}
	}
}