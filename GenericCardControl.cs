using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCardGenerator
{
	public delegate void SomethingChangedEventHandler(object sender, EventArgs e);

	public partial class GenericCardControl : UserControl
	{
		public event SomethingChangedEventHandler SomethingChanged;

		public GameObject GameObject { get; set; }

		public GenericCardControl()
		{
			InitializeComponent();
		}

		public GenericCardControl(GameObject gameObject)
		{
			InitializeComponent();
			GameObject = gameObject;
			// Additional initialization if needed
		}

		public void RefreshControl()
		{
			if (GameObject == null)
				return;

			this.lblName.Text = GameObject.Name;

			// Liberar imagen previa de pctIcon
			if (this.pctIcon.Image != null && this.pctIcon.Image != GameObject.Icon)
			{
				this.pctIcon.Image.Dispose();
				this.pctIcon.Image = null;
			}

			if (string.IsNullOrEmpty(GameObject.Class))
			{
				this.topPanel.BackgroundImage = Properties.Resources.Generic_Line;
				this.lblName.ForeColor = Color.White;
				this.lblRarity.ForeColor = Color.LightGray;
				this.lblType.ForeColor = Color.LightGray;
				this.pctIcon.Image = GameObject.Icon;
				this.pctIcon.Visible = true;
			}
			else
			{
				this.topPanel.BackgroundImage = Properties.Resources.ResourceManager.GetObject($"{GameObject.Class}_Line") as Image;
				this.lblName.ForeColor = Constants.ClassColors[GameObject.Class].ForeColor;
				this.lblRarity.ForeColor = lblName.ForeColor == Color.White ? Color.LightGray : Color.FromArgb(45, 45, 45);
				this.lblType.ForeColor = lblName.ForeColor == Color.White ? Color.LightGray : Color.FromArgb(45, 45, 45);
				this.pctIcon.Visible = false;
			}

			this.lblType.Text = GameObject.Type.ToString();
			this.lblRarity.Text = GameObject.Rarity.ToString();
			this.lblBottomText.Text = GameObject.BottomText.ToUpper();

			UpdateDescription();
		}

		private void GenericCardControl_Load(object sender, EventArgs e)
		{
			if (GameObject != null)
			{
				// Load the GameObject data into the control
				// For example, you might set labels or other controls based on GameObject properties
				this.Text = GameObject.Name; // Assuming GameObject has a Name property
				UpdateDescription();
			}
		}

		private void UpdateDescription()
		{
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

			string[] lines = GameObject.Description.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

			foreach (string line in lines)
			{
				if (line.Trim() == "---")
				{
					// Renderizar la imagen de línea
					PictureBox pb = new PictureBox();
					pb.Image = (Image)Properties.Resources.Line.Clone();
					pb.SizeMode = PictureBoxSizeMode.StretchImage;
					pb.Height = 3;
					pb.Width = this.flowDescriptionPanel.Width - 10;
					pb.Margin = new Padding(0, 5, 0, 5);
					this.flowDescriptionPanel.Controls.Add(pb);
					continue;
				}

				RichTextBox rtb = new RichTextBox();
				rtb.BorderStyle = BorderStyle.None;
				rtb.ReadOnly = true;
				rtb.BackColor = this.flowDescriptionPanel.BackColor;
				rtb.Font = new Font("MPlantin", 20F, FontStyle.Regular);

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
					TextRenderer.MeasureText(rtb.Text, rtb.Font).Height + 10,
					(int)Math.Ceiling(rtb.GetPositionFromCharIndex(rtb.TextLength - 1).Y + rtb.Font.Height * 1.1)
				);

				this.flowDescriptionPanel.Controls.Add(rtb);
			}
		}
	}
}
