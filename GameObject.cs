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
		public GameObjectType Type { get; set; }
		public string Class { get; set; } = string.Empty;
		public Image Icon { get; set; }
	}
}
