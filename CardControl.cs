using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpellCardsDnDGenerator
{
	public delegate void SomethingChangedEventHandler(object sender, EventArgs e);

	public partial class CardControl : UserControl
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

		public CardControl()
		{
			InitializeComponent();
		}

		public void SetClass(string className)
		{
			switch (className)
			{
				case "Bardo":
					topPanel.BackgroundImage = Properties.Resources.BardLine;
					panelRandom.BackColor = Constants.Colors.ClassColors.Bard.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Bard.ForeColor;
					break;
				case "Bárbaro":
					topPanel.BackgroundImage = Properties.Resources.BarbarianLine;
					panelRandom.BackColor = Constants.Colors.ClassColors.Barbarian.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Barbarian.ForeColor;
					break;
				case "Paladin":
					topPanel.BackgroundImage = Properties.Resources.PaladinLine;
					panelRandom.BackColor = Constants.Colors.ClassColors.Paladin.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Paladin.ForeColor;
					break;
				case "Explorador":
					topPanel.BackgroundImage = Properties.Resources.RangerLine;
					panelRandom.BackColor = Constants.Colors.ClassColors.Ranger.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Ranger.ForeColor;
					break;
				case "Clérigo":
					topPanel.BackgroundImage = Properties.Resources.Cleric_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Cleric.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Cleric.ForeColor;
					break;
				case "Druida":
					topPanel.BackgroundImage = Properties.Resources.Druid_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Druid.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Druid.ForeColor;
					break;
				case "Hechicero":
					topPanel.BackgroundImage = Properties.Resources.Sorcerer_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Sorcerer.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Sorcerer.ForeColor;
					break;
				case "Brujo":
					topPanel.BackgroundImage = Properties.Resources.Warlock_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Warlock.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Warlock.ForeColor;
					break;
				case "Guerrero":
					topPanel.BackgroundImage = Properties.Resources.Fighter_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Fighter.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Fighter.ForeColor;
					break;
				case "Mago":
					topPanel.BackgroundImage = Properties.Resources.Wizard_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Wizard.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Wizard.ForeColor;
					break;
				case "Monje":
					topPanel.BackgroundImage = Properties.Resources.Monk_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Monk.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Monk.ForeColor;
					break;
				default:
					topPanel.BackgroundImage = Properties.Resources.Rogue_Line;
					panelRandom.BackColor = Constants.Colors.ClassColors.Rogue.BackColor;
					lblSpellName.ForeColor = Constants.Colors.ClassColors.Rogue.ForeColor;
					break;
			}

			if(_spell != null)
				_spell.Class = className;

			lblClass.Text = className.ToUpper();
			SetSchool(lblSchool.Text);;

			if (!_isUpdating && SomethingChanged != null)
				SomethingChanged(this, EventArgs.Empty);
		}

		public void SetSpellName(string name)
		{
			lblSpellName.Text = name;

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
			lblDescription.Text = description;
			if (_spell != null)
				_spell.Description = description;

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
