using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DnDCardGenerator
{
	public partial class fMain : Form
	{
		Spell currentSpell = new Spell();
		SpellCardControl cardControl = new SpellCardControl();
		GameObject currentObject = new GameObject();
		GenericCardControl genericCardControl = new GenericCardControl();

		bool isSpellCard = true;

		public fMain()
		{
			InitializeComponent();

			cbMaterial.CheckedChanged += cbMaterial_Changed;
			cardControl.SomethingChanged += Something_Changed;
			genericCardControl.SomethingChanged += Something_Changed;

			UpdateSpellFromInputs();
			cardControl.Spell = currentSpell;

			UpdateObjectFromInputs();
			genericCardControl.GameObject = currentObject;
			genericCardControl.RefreshControl();

			UpdatePreview();
		}

		private void cbMaterial_Changed(object sender, EventArgs e)
		{
			txtMaterialCost.Enabled = cbMaterial.Checked;
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void Something_Changed(object sender, EventArgs e)
		{
			UpdatePreview();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if (isSpellCard)
			{
				UpdateSpellFromInputs();
			}
			else
			{
				UpdateObjectFromInputs();
			}
			UpdatePreview();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			Control previewControl = isSpellCard ? (Control)cardControl : (Control)genericCardControl;
			using (Bitmap bitmap = new Bitmap(previewControl.Width, previewControl.Height))
			{
				previewControl.DrawToBitmap(bitmap, new Rectangle(0, 0, previewControl.Width, previewControl.Height));
				Clipboard.SetImage(bitmap);
			}
			MessageBox.Show("La carta ha sido copiada al portapapeles como imagen.", "Exportar Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtRange_TextChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{
			if (isSpellCard)
			{
				UpdateSpellFromInputs();
			}
			else
			{
				UpdateObjectFromInputs();
			}
			UpdatePreview();
		}

		private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void txtCastingTime_TextChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void txtDuration_TextChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void cbSovietic_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void txtMaterialCost_TextChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void txtLevel_TextChanged(object sender, EventArgs e)
		{
			UpdateSpellFromInputs();
			UpdatePreview();
		}

		private void UpdateSpellFromInputs()
		{
			currentSpell.Name = txtName.Text;
			currentSpell.Level = txtLevel.Text;
			currentSpell.School = cbSchool.SelectedItem != null ? cbSchool.SelectedItem.ToString() : string.Empty;
			currentSpell.Class = cbClass.SelectedItem != null ? cbClass.SelectedItem.ToString() : string.Empty;
			currentSpell.CastingTime = txtCastingTime.Text;
			currentSpell.Range = txtRange.Text;
			currentSpell.Duration = txtDuration.Text;
			currentSpell.Description = txtDescription.Text;
			currentSpell.MaterialCost = txtMaterialCost.Text;
			currentSpell.Components = string.Format("{0}{1}{2}{3}{4}",
				cbConcentration.Checked ? "C" : "",
				cbMaterial.Checked ? "M" : "",
				cbVerbal.Checked ? "V" : "",
				cbSovietic.Checked ? "S" : "",
				cbRitual.Checked ? "R" : "");

			cardControl.Spell = currentSpell;
		}

		private void UpdateObjectFromInputs()
		{
			// Inputs para la carta genérica
			currentObject.Name = txtGenericName.Text;
			currentObject.Description = txtGenericDescription.Text;

			switch (cbIcon.SelectedItem != null ? cbIcon.SelectedItem.ToString() : "")
			{
				case "Acción":
					currentObject.Icon = Properties.Resources.Barbarian_White;
					break;
				case "Objeto":
					currentObject.Icon = Properties.Resources.Illusion_White;
					break;
				case "Clase: Bárbaro":
					currentObject.Icon = Properties.Resources.Barbarian_White;
					break;
				case "Clase: Bardo":
					currentObject.Icon = Properties.Resources.Bard_White;
					break;
				case "Clase: Clérigo":
					currentObject.Icon = Properties.Resources.Cleric_White;
					break;
				case "Clase: Druida":
					currentObject.Icon = Properties.Resources.Druid_White;
					break;
				case "Clase: Guerrero":
					currentObject.Icon = Properties.Resources.Fighter_White;
					break;
				case "Clase: Paladín":
					currentObject.Icon = Properties.Resources.Paladin_White;
					break;
				case "Clase: Pícaro":
					currentObject.Icon = Properties.Resources.Rogue_White;
					break;
				case "Clase: Hechicero":
					currentObject.Icon = Properties.Resources.Sorcerer_White;
					break;
				case "Clase: Explorador":
					currentObject.Icon = Properties.Resources.Ranger_White;
					break;
				case "Clase: Warlock":
					currentObject.Icon = Properties.Resources.Warlock_White;
					break;
				case "Clase: Monje":
					currentObject.Icon = Properties.Resources.Monk_White;
					break;
				default:
					currentObject.Icon = null;
					break;
			}

			// Puedes agregar más propiedades si tu modelo GameObject lo requiere
			genericCardControl.GameObject = currentObject;
			genericCardControl.RefreshControl();
		}

		private void UpdatePreview()
		{
			Control previewControl = isSpellCard ? (Control)cardControl : (Control)genericCardControl;
			Bitmap bmp = new Bitmap(previewControl.Width, previewControl.Height);
			previewControl.DrawToBitmap(bmp, new Rectangle(0, 0, previewControl.Width, previewControl.Height));
			pctPreviewCard.Image = bmp;
			pctPreviewCard.SizeMode = PictureBoxSizeMode.Zoom;
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			FileDialog fileDialog = new OpenFileDialog();
			fileDialog.Title = "Importar hechizos desde JSON";
			fileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";

			string exportPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string json = System.IO.File.ReadAllText(fileDialog.FileName);
					List<Spell> spells = JsonConvert.DeserializeObject<List<Spell>>(json);

					if (spells == null || spells.Count == 0)
					{
						MessageBox.Show("No se encontraron hechizos en el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					MessageBox.Show(string.Format("Se exportarán {0} cartas. Elije una carpeta para guardarlos.", spells.Count), "Hechizos encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);

					FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
					folderBrowser.Description = "Seleccione la carpeta donde desea exportar las cartas.";
					folderBrowser.RootFolder = Environment.SpecialFolder.MyDocuments;
					folderBrowser.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

					if (folderBrowser.ShowDialog() == DialogResult.OK)
					{
						exportPath = folderBrowser.SelectedPath;
					}
					else
					{
						return; // Si el usuario cancela, no hacemos nada
					}

					int exportedCount = 0;
					int spellsCount = spells.Count;

					// Mostrar un formulario de progreso
					Form progressForm = new Form();
					progressForm.Text = "Exportando hechizos...";
					progressForm.Size = new Size(300, 100);
					progressForm.StartPosition = FormStartPosition.CenterScreen;
					progressForm.FormBorderStyle = FormBorderStyle.FixedDialog;
					progressForm.MaximizeBox = false;
					progressForm.MinimizeBox = false;
					progressForm.ShowInTaskbar = false;
					progressForm.ControlBox = false;
					Label lblProgress = new Label();
					lblProgress.TextAlign = ContentAlignment.MiddleCenter;
					lblProgress.Text = "Exportando hechizos, por favor espere...";
					lblProgress.Location = new Point(20, 7);
					lblProgress.Width = 240;
					System.Windows.Forms.ProgressBar progressBar = new System.Windows.Forms.ProgressBar();
					progressBar.Style = ProgressBarStyle.Blocks;
					progressBar.Location = new Point(20, 30);
					progressBar.Width = 240;
					progressBar.Minimum = 0;
					progressBar.Maximum = spellsCount;
					progressBar.Height = 20;
					progressForm.Controls.Add(progressBar);
					progressForm.Controls.Add(lblProgress);
					progressForm.Show();
					Application.DoEvents(); // Permite que la UI se actualice


					foreach (Spell spell in spells)
					{
						cardControl.Spell = spell;
						UpdatePreview();

						using (Bitmap bitmap = new Bitmap(cardControl.Width, cardControl.Height))
						{
							cardControl.DrawToBitmap(bitmap, new Rectangle(0, 0, cardControl.Width, cardControl.Height));
							string fileName = System.IO.Path.Combine(exportPath, $"{spell.Name}.png");
							bitmap.Save(fileName);
						}
						lblProgress.Text = $"Exportando: {spell.Name} ({++exportedCount}/{spellsCount})";
						progressBar.Value = exportedCount;
						Application.DoEvents();
					}

					progressForm.Close();
					MessageBox.Show("Cartas exportadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnExportJSON_Click(object sender, EventArgs e)
		{
			if (isSpellCard)
			{
				Clipboard.SetText(JsonConvert.SerializeObject(cardControl.Spell, Formatting.Indented));
				MessageBox.Show("El hechizo actual ha sido copiado al portapapeles en formato JSON.", "Exportar JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Clipboard.SetText(JsonConvert.SerializeObject(genericCardControl.GameObject, Formatting.Indented));
				MessageBox.Show("La carta ha sido copiada al portapapeles en formato JSON.", "Exportar JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnSpellType_Click(object sender, EventArgs e)
		{
			this.isSpellCard = true;
			UpdateUI();
			UpdatePreview();
		}

		private void btnGenericType_Click(object sender, EventArgs e)
		{
			this.isSpellCard = false;
			UpdateUI();
			UpdatePreview();
		}

		private void UpdateUI()
		{
			if (this.isSpellCard)
			{
				btnSpellType.FillColor = Color.FromArgb(224, 224, 224);
				btnSpellType.FillColor2 = Color.FromArgb(224, 224, 224);
				btnGenericType.FillColor = Color.White;
				btnGenericType.FillColor2 = Color.White;
				pages.SelectedTab = pages.TabPages["pageSpells"];
			}
			else
			{
				btnSpellType.FillColor = Color.White;
				btnSpellType.FillColor2 = Color.White;
				btnGenericType.FillColor = Color.FromArgb(224, 224, 224);
				btnGenericType.FillColor2 = Color.FromArgb(224, 224, 224);
				pages.SelectedTab = pages.TabPages["pageGeneric"];
			}
		}

		private void txtGenericDescription_TextChanged(object sender, EventArgs e)
		{
			UpdateObjectFromInputs();
			UpdatePreview();
		}

		private void txtGenericName_TextChanged(object sender, EventArgs e)
		{
			UpdateObjectFromInputs();
			UpdatePreview();
		}

		private void cbIcon_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateObjectFromInputs();
			UpdatePreview();
		}
	}
}
