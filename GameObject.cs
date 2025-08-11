using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCardGenerator
{
	public class GameObject
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Type { get; set; } = "Acción";
		public string Rarity { get; set; } = "Común";
		public string BottomText { get; set; } = "Acción";
		public string Class { get; set; } = string.Empty;

		[JsonIgnore]
		public Image Icon { get; set; } = Properties.Resources.Throw_White;
	}
}
