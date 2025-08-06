using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCardGenerator
{
	internal class Constants
	{
		public class Colors
		{
			public static class ClassColors
			{
				public static class Barbarian
				{
					public static readonly Color BackColor = Color.FromArgb(231, 98, 62);
					public static readonly Color ForeColor = Color.FromArgb(0, 0, 0);
				}

				public static class Bard
				{
					public static readonly Color BackColor = Color.FromArgb(171, 109, 172);
					public static readonly Color ForeColor = Color.FromArgb(0, 0, 0);
				}

				public static class Paladin
				{
					public static readonly Color BackColor = Color.FromArgb(181, 158, 84);
					public static readonly Color ForeColor = Color.FromArgb(0, 0, 0);
				}

				public static class Ranger
				{
					public static readonly Color BackColor = Color.FromArgb(80, 127, 98);
					public static readonly Color ForeColor = Color.White;
				}

				public static class Cleric
				{
					public static readonly Color BackColor = Color.FromArgb(145, 161, 178);
					public static readonly Color ForeColor = Color.FromArgb(0, 0, 0);
				}

				public static class Rogue
				{
					public static readonly Color BackColor = Color.FromArgb(85, 87, 82);
					public static readonly Color ForeColor = Color.White;
				}

				public static class Druid
				{
					public static readonly Color BackColor = Color.FromArgb(122, 133, 59);
					public static readonly Color ForeColor = Color.FromArgb(0, 0, 0);
				}

				public static class Sorcerer
				{
					public static readonly Color BackColor = Color.FromArgb(153, 46, 46);
					public static readonly Color ForeColor = Color.White;
				}

				public static class Fighter { 
					public static readonly Color BackColor = Color.FromArgb(127, 81, 62);
					public static readonly Color ForeColor = Color.White;
				}

				public static class Warlock { 
					public static readonly Color BackColor = Color.FromArgb(123, 70, 155);
					public static readonly Color ForeColor = Color.White;
				}

				public static class Monk
				{
					public static readonly Color BackColor = Color.FromArgb(81, 165, 197);
					public static readonly Color ForeColor = Color.FromArgb(0, 0, 0);
				}

				public static class Wizard
				{
					public static readonly Color BackColor = Color.FromArgb(42, 80, 161);
					public static readonly Color ForeColor = Color.White;
				}
			}

			public static readonly Color InactiveText = Color.FromArgb(153, 153, 153);
		}
	}
}
