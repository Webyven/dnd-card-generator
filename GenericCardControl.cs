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
			UpdateType();
			UpdateDescription();
		}

		private void UpdateType()
		{
			this.lblClass.Text = GameObject.Type.ToString();

			switch (GameObject.Type)
			{
				case GameObjectType.Item:
					this.lblClass.Text = "OBJETO";
					break;
				case GameObjectType.Action:
					this.lblClass.Text = "ACCIÓN";
					break;
				case GameObjectType.ClassObject:
					this.lblClass.Text = GameObject.Class.ToUpper();
					break;
				default:
					break;
			}
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
			this.flowDescriptionPanel.Controls.Clear();
			string[] lines = GameObject.Description.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

			foreach (string line in lines)
			{
				if (line.Trim() == "---")
				{
					// Renderizar la imagen de línea
					PictureBox pb = new PictureBox();
					pb.Image = Properties.Resources.Line;
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
