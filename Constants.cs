using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCardGenerator
{
	public static class Constants
	{
		public class ClassTypes
		{
			public const string Barbarian = "Bárbaro";
			public const string Bard = "Bardo";
			public const string Paladin = "Paladin";
			public const string Ranger = "Explorador";
			public const string Cleric = "Clérigo";
			public const string Rogue = "Pícaro";
			public const string Druid = "Druida";
			public const string Sorcerer = "Hechicero";
			public const string Fighter = "Guerrero";
			public const string Warlock = "Brujo";
			public const string Monk = "Monje";
			public const string Wizard = "Mago";
		}

		public class EnglishClassTypes
		{
			public const string Barbarian = "Barbarian";
			public const string Bard = "Bard";
			public const string Paladin = "Paladin";
			public const string Ranger = "Ranger";
			public const string Cleric = "Cleric";
			public const string Rogue = "Rogue";
			public const string Druid = "Druid";
			public const string Sorcerer = "Sorcerer";
			public const string Fighter = "Fighter";
			public const string Warlock = "Warlock";
			public const string Monk = "Monk";
			public const string Wizard = "Wizard";
		}

		public class ColorInfo
		{
			public Color BackColor { get; set; }
			public Color ForeColor { get; set; }
		}

		public static readonly Dictionary<string, ColorInfo> ClassColors = new Dictionary<string, ColorInfo>
		{
			{ ClassTypes.Barbarian, new ColorInfo { BackColor = Color.FromArgb(231, 98, 62),   ForeColor = Color.Black } },
			{ EnglishClassTypes.Barbarian, new ColorInfo { BackColor = Color.FromArgb(231, 98, 62), ForeColor = Color.Black } },
			{ ClassTypes.Bard,      new ColorInfo { BackColor = Color.FromArgb(171, 109, 172), ForeColor = Color.Black } },
			{ EnglishClassTypes.Bard, new ColorInfo { BackColor = Color.FromArgb(171, 109, 172), ForeColor = Color.Black } },
			{ ClassTypes.Paladin,   new ColorInfo { BackColor = Color.FromArgb(181, 158, 84),  ForeColor = Color.Black } },
			{ ClassTypes.Ranger,    new ColorInfo { BackColor = Color.FromArgb(80, 127, 98),   ForeColor = Color.White } },
			{ EnglishClassTypes.Ranger, new ColorInfo { BackColor = Color.FromArgb(80, 127, 98), ForeColor = Color.White } },
			{ ClassTypes.Cleric,    new ColorInfo { BackColor = Color.FromArgb(145, 161, 178), ForeColor = Color.Black } },
			{ EnglishClassTypes.Cleric, new ColorInfo { BackColor = Color.FromArgb(145, 161, 178), ForeColor = Color.Black } },
			{ ClassTypes.Rogue,     new ColorInfo { BackColor = Color.FromArgb(85, 87, 82),    ForeColor = Color.White } },
			{ EnglishClassTypes.Rogue, new ColorInfo { BackColor = Color.FromArgb(85, 87, 82), ForeColor = Color.White } },
			{ ClassTypes.Druid,     new ColorInfo { BackColor = Color.FromArgb(122, 133, 59),  ForeColor = Color.Black } },
			{ EnglishClassTypes.Druid, new ColorInfo { BackColor = Color.FromArgb(122, 133, 59), ForeColor = Color.Black } },
			{ ClassTypes.Sorcerer,  new ColorInfo { BackColor = Color.FromArgb(153, 46, 46),   ForeColor = Color.White } },
			{ EnglishClassTypes.Sorcerer, new ColorInfo { BackColor = Color.FromArgb(153, 46, 46), ForeColor = Color.White } },
			{ ClassTypes.Fighter,   new ColorInfo { BackColor = Color.FromArgb(127, 81, 62),   ForeColor = Color.White } },
			{ EnglishClassTypes.Fighter, new ColorInfo { BackColor = Color.FromArgb(127, 81, 62), ForeColor = Color.White } },
			{ ClassTypes.Warlock,   new ColorInfo { BackColor = Color.FromArgb(123, 70, 155),  ForeColor = Color.White } },
			{ EnglishClassTypes.Warlock, new ColorInfo { BackColor = Color.FromArgb(123, 70, 155), ForeColor = Color.White } },
			{ ClassTypes.Monk,      new ColorInfo { BackColor = Color.FromArgb(81, 165, 197),  ForeColor = Color.Black } },
			{ EnglishClassTypes.Monk, new ColorInfo { BackColor = Color.FromArgb(81, 165, 197), ForeColor = Color.Black } },
			{ ClassTypes.Wizard,    new ColorInfo { BackColor = Color.FromArgb(42, 80, 161),   ForeColor = Color.White } },
			{ EnglishClassTypes.Wizard, new ColorInfo { BackColor = Color.FromArgb(42, 80, 161), ForeColor = Color.White } }
		};
	}
}
