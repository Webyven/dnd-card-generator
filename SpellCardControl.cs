using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DnDCardGenerator
{
	public partial class SpellCardControl : UserControl
	{
		public event SomethingChangedEventHandler SomethingChanged;
		private Spell _spell = new Spell();
		public Spell Spell
		{
			get => _spell;
			set
			{
				_spell = value;
				UpdateUIFromSpell();
				SomethingChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		private bool _isUpdating = false;
		public void BeginUpdate() => _isUpdating = true;
		public void EndUpdate()
		{
			_isUpdating = false;
			SomethingChanged?.Invoke(this, EventArgs.Empty);
		}

		private void UpdateUIFromSpell()
		{
			if (_spell == null) return;

			BeginUpdate();
			SetSpellName(_spell.Name);
			SetLevel(_spell.Level);
			SetSchool(_spell.School);
			SetClass(_spell.Class);
			SetCastingTime(_spell.CastingTime);
			SetRange(_spell.Range);
			SetDuration(_spell.Duration);
			SetComponents(_spell.Components);
			SetDescription(_spell.Description);
			SetMaterialCost(_spell.MaterialCost);
			EndUpdate();
		}

		public SpellCardControl()
		{
			InitializeComponent();
		}

		public void SetClass(string className)
		{
			switch (className)
			{
				case Constants.ClassTypes.Bard:
					topPanel.BackgroundImage = Properties.Resources.Bard_Line;
					break;
				case Constants.ClassTypes.Barbarian:
					topPanel.BackgroundImage = Properties.Resources.Barbarian_Line;
					break;
				case Constants.ClassTypes.Paladin:
					topPanel.BackgroundImage = Properties.Resources.Paladin_Line;
					break;
				case Constants.ClassTypes.Ranger:
					topPanel.BackgroundImage = Properties.Resources.Ranger_Line;
					break;
				case Constants.ClassTypes.Cleric:
					topPanel.BackgroundImage = Properties.Resources.Cleric_Line;
					break;
				case Constants.ClassTypes.Druid:
					topPanel.BackgroundImage = Properties.Resources.Druid_Line;
					break;
				case Constants.ClassTypes.Sorcerer:
					topPanel.BackgroundImage = Properties.Resources.Sorcerer_Line;
					break;
				case Constants.ClassTypes.Warlock:
					topPanel.BackgroundImage = Properties.Resources.Warlock_Line;
					break;
				case Constants.ClassTypes.Fighter:
					topPanel.BackgroundImage = Properties.Resources.Fighter_Line;
					break;
				case Constants.ClassTypes.Wizard:
					topPanel.BackgroundImage = Properties.Resources.Wizard_Line;
					break;
				case Constants.ClassTypes.Monk:
					topPanel.BackgroundImage = Properties.Resources.Monk_Line;
					break;
				default:
					topPanel.BackgroundImage = Properties.Resources.Rogue_Line;
					break;
			}

			panelRandom.BackColor = Constants.ClassColors[className].BackColor;
			lblSpellName.ForeColor = Constants.ClassColors[className].ForeColor;

			if (_spell != null)
				_spell.Class = className;

			lblClass.Text = className.ToUpper();
			SetSchool(lblSchool.Text);;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetSpellName(string name)
		{
			lblSpellName.Text = name;
			lblSpellName.Font = new Font("Ringbearer", _spell.SpellNameFontSize, FontStyle.Bold);

			if (_spell != null)
				_spell.Name = name;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetRange(string range)
		{
			lblRange.Text = range;

			if (_spell != null)
				_spell.Range = range;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetDuration(string duration)
		{
			lblDuration.Text = duration;

			if (_spell != null)
				_spell.Duration = duration;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetLevel(string level)
		{
			lblLevel.Text = level;

			if (_spell != null)
				_spell.Level = level;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetCastingTime(string castingTime)
		{
			lblCastTime.Text = castingTime;

			if (_spell != null)
				_spell.CastingTime = castingTime;

			pctActionType.Visible = false;

			foreach (var ActionType in Constants.ActionTypes)
			{
				if (castingTime.ToLower().Contains(ActionType.Key.ToLower()))
				{
					pctActionType.Image = ActionType.Value;
					pctActionType.Visible = true;
					break;
				}
			}

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetSchool(string school)
		{
			lblSchool.Text = school;
			if (_spell != null)
				_spell.School = school;

			switch (school)
			{
				case "Abjuración":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Abjuration_White : Properties.Resources.Abjuration;
					break;
				case "Conjuración":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Conjuration_White :  Properties.Resources.Conjuration;
					break;
				case "Adivinación":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Divination_White : Properties.Resources.Divination;
					break;
				case "Encantamiento":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Enchantment_White : Properties.Resources.Enchantment;
					break;
				case "Evocación":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Evocation_White : Properties.Resources.Evocation;
					break;
				case "Ilusión":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Illusion_White : Properties.Resources.Illusion;
					break;
				case "Necromancia":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Necromancy_White : Properties.Resources.Necromancy;
					break;
				case "Transmutación":
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Transmutation_White : Properties.Resources.Transmutation;
					break;
				default:
					panelSchool.BackgroundImage = lblSpellName.ForeColor == Color.White ? Properties.Resources.Conjuration_White : Properties.Resources.Conjuration;
					break;
			}

			lblSchool.ForeColor = lblSpellName.ForeColor;
			lblLevel.ForeColor = lblSchool.ForeColor == Color.White ? Color.LightGray : Color.FromArgb(45, 45, 45);
			lblRitual.ForeColor = lblSchool.ForeColor == Color.White ? Color.LightGray : Color.FromArgb(45, 45, 45);

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetComponents(bool concentration, bool ritual, bool material, bool verbal, bool sovietic)
		{
			this.pctConcentration.Visible = concentration;
			this.lblRitual.Visible = ritual;
			this.lblMaterial.ForeColor = material ? Color.Black : Color.Silver;
			this.lblMaterialGold.Visible = material;
			this.lblVerbal.ForeColor = verbal ? Color.Black : Color.Silver;
			this.lblSovietic.ForeColor = sovietic ? Color.Black : Color.Silver;

			if (_spell != null)
			{
				_spell.Components = $"{(concentration ? "C" : "")}{(material ? "M" : "")}{(verbal ? "V" : "")}{(sovietic ? "S" : "")}{(ritual ? "R" : "")}";
			}

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetComponents(string components)
		{
			this.pctConcentration.Visible = components.Contains("C");
			this.lblMaterial.ForeColor = components.Contains("M") ? Color.Black : Color.Silver;
			this.lblMaterialGold.Visible = components.Contains("M");
			this.lblVerbal.ForeColor = components.Contains("V") ? Color.Black : Color.Silver;
			this.lblSovietic.ForeColor = components.Contains("S") ? Color.Black : Color.Silver;
			this.lblRitual.Visible = components.Contains("R");

			if (_spell != null)
				_spell.Components = components;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetDescription(string description)
		{
			if (_spell != null)
				_spell.Description = description;

			// Liberar recursos de controles previos
			foreach (Control ctrl in this.flowDescriptionPanel.Controls)
			{
				if (ctrl is PictureBox pb && pb.Image != null)
				{
					pb.Image.Dispose();
					pb.Image = null;
				}
				ctrl.Dispose();
			}
			this.flowDescriptionPanel.Controls.Clear();

			string[] lines = description.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

			foreach (string line in lines)
			{
				// Si usas PictureBox para líneas, aquí deberías clonar la imagen igual que en GenericCardControl
				// Ejemplo:
				// if (line.Trim() == "---")
				// {
				//     PictureBox pb = new PictureBox();
				//     pb.Image = (Image)Properties.Resources.Line.Clone();
				//     pb.SizeMode = PictureBoxSizeMode.StretchImage;
				//     pb.Height = 3;
				//     pb.Width = this.flowDescriptionPanel.Width - 10;
				//     pb.Margin = new Padding(0, 5, 0, 5);
				//     this.flowDescriptionPanel.Controls.Add(pb);
				//     continue;
				// }

				RichTextBox rtb = new RichTextBox();
				rtb.BorderStyle = BorderStyle.None;
				rtb.ReadOnly = true;
				rtb.BackColor = this.flowDescriptionPanel.BackColor;
				rtb.Font = new Font("MPlantin", Spell.SpellFontSize, FontStyle.Regular);

				int start = 0;
				bool bold = false;
				bool italic = false;
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == '*' || line[i] == '_')
					{
						if (i > start)
						{
							rtb.SelectionStart = rtb.TextLength;
							rtb.SelectionLength = 0;
							FontStyle style = FontStyle.Regular;
							if (bold && italic)
								style = FontStyle.Bold | FontStyle.Italic;
							else if (bold)
								style = FontStyle.Bold;
							else if (italic)
								style = FontStyle.Italic;

							rtb.SelectionFont = new Font(rtb.Font, style);
							rtb.AppendText(line.Substring(start, i - start));
						}
						if (line[i] == '*')
							bold = !bold;
						else
							italic = !italic;
						start = i + 1;
					}
				}
				if (start < line.Length)
				{
					rtb.SelectionStart = rtb.TextLength;
					rtb.SelectionLength = 0;
					FontStyle style = FontStyle.Regular;
					if (bold && italic)
						style = FontStyle.Bold | FontStyle.Italic;
					else if (bold)
						style = FontStyle.Bold;
					else if (italic)
						style = FontStyle.Italic;

					rtb.SelectionFont = new Font(rtb.Font, style);
					rtb.AppendText(line.Substring(start));
				}
				rtb.ScrollBars = RichTextBoxScrollBars.None;
				rtb.Width = this.flowDescriptionPanel.Width - 10;

				rtb.Height = Math.Max(
					TextRenderer.MeasureText(rtb.Text, rtb.Font).Height + 20,
					(int)Math.Ceiling(rtb.GetPositionFromCharIndex(rtb.TextLength - 1).Y + rtb.Font.Height * 1.1)
				);

				this.flowDescriptionPanel.Controls.Add(rtb);
			}

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetMaterialCost(string materialCost)
		{
			this.lblMaterialGold.Text = materialCost;

			if (_spell != null)
				_spell.MaterialCost = materialCost;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}
	}
}
