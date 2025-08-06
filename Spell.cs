using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCardGenerator
{
	public class Spell : GameObject
	{
		public string Level { get; set; }
		public string School { get; set; }
		public string CastingTime { get; set; }
		public string Range { get; set; }
		public string Components { get; set; }
		public string Duration { get; set; }
		public string MaterialCost { get; set; } 

		public Spell() { }
	}
}
