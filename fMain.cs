using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpellCardsDnDGenerator
{
	public partial class fMain : Form
	{
		SpellCardControl cardControl = new SpellCardControl();

		bool isSpellCard = true;

		public fMain()
		{
			InitializeComponent();

			// Renderiza el CardControl a un Bitmap
			Bitmap bmp = new Bitmap(cardControl.Width, cardControl.Height);
			cardControl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
			cbMaterial.CheckedChanged += cbMaterial_Changed;

			// Muestra el Bitmap en un PictureBox
			pctPreviewCard.Image = bmp;
			pctPreviewCard.SizeMode = PictureBoxSizeMode.Zoom; // Mantiene la relación de aspecto
			cardControl.SomethingChanged += Something_Changed;
			cardControl.SetDescription(txtDescription.Text);
		}

		private void cbMaterial_Changed(object sender, EventArgs e)
		{
			txtMaterialCost.Enabled = cbMaterial.Checked;
		}

		private void Something_Changed(object sender, EventArgs e)
		{
			// Renderiza el CardControl a un Bitmap
			Bitmap bmp = new Bitmap(cardControl.Width, cardControl.Height);
			cardControl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
			// Actualiza el PictureBox con el nuevo Bitmap
			pctPreviewCard.Image = bmp;
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			cardControl.SetSpellName(txtName.Text);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			// Exportar cardControl como imagen
			using (Bitmap bitmap = new Bitmap(cardControl.Width, cardControl.Height))
			{
				cardControl.DrawToBitmap(bitmap, new Rectangle(0, 0, cardControl.Width, cardControl.Height));
				Clipboard.SetImage(bitmap);
			}
			MessageBox.Show("La carta ha sido copiada al portapapeles como imagen.", "Exportar Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtRange_TextChanged(object sender, EventArgs e)
		{
			cardControl.SetRange(txtRange.Text);
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{
			cardControl.SetDescription(txtDescription.Text);
		}

		private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
		{
			cardControl.SetSchool(cbSchool.SelectedItem.ToString());
		}

		private void txtCastingTime_TextChanged(object sender, EventArgs e)
		{
			cardControl.SetCastingTime(txtCastingTime.Text);
		}

		private void txtDuration_TextChanged(object sender, EventArgs e)
		{
			cardControl.SetDuration(txtDuration.Text);
		}

		private void cbSovietic_CheckedChanged(object sender, EventArgs e)
		{
			cardControl.SetComponents(cbConcentration.Checked,
				cbRitual.Checked,
				cbMaterial.Checked,
				cbVerbal.Checked,
				cbSovietic.Checked
			);
		}

		private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			cardControl.SetClass(cbClass.SelectedItem.ToString());
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
						// Actualizar la vista previa
						Something_Changed(this, EventArgs.Empty);

						// Exportar la imagen del CardControl
						using (Bitmap bitmap = new Bitmap(cardControl.Width, cardControl.Height))
						{
							cardControl.DrawToBitmap(bitmap, new Rectangle(0, 0, cardControl.Width, cardControl.Height));
							string fileName = System.IO.Path.Combine(exportPath, $"{spell.Name}.png");
							bitmap.Save(fileName);
						}
						lblProgress.Text = $"Exportando: {spell.Name} ({++exportedCount}/{spellsCount})";
						progressBar.Value = exportedCount;
						Application.DoEvents(); // Permite que la UI se actualice
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
			Clipboard.SetText(JsonConvert.SerializeObject(cardControl.Spell, Formatting.Indented));
			MessageBox.Show("El hechizo actual ha sido copiado al portapapeles en formato JSON.", "Exportar JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtMaterialCost_TextChanged(object sender, EventArgs e)
		{
			cardControl.SetMaterialCost(txtMaterialCost.Text);
		}

		private void txtLevel_TextChanged(object sender, EventArgs e)
		{
			cardControl.SetLevel(txtLevel.Text);
		}

		private void btnSpellType_Click(object sender, EventArgs e)
		{
			this.isSpellCard = true;
			UpdateUI();
		}

		private void btnGenericType_Click(object sender, EventArgs e)
		{
			this.isSpellCard = false;
			UpdateUI();
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
	}
}
